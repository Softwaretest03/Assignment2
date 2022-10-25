using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Ladeskab.Interfaces;

namespace Ladeskab;

public class StationControl
{
    // Enum med tilstande ("states") svarende til tilstandsdiagrammet for klassen
    private enum LadeskabState
    {
        Available,
        Locked,
        DoorOpen
    };

    // Her mangler flere member variable
    private LadeskabState _state;
    //private Library.IChargeControl _charger;
    private int _oldId;
    private Library.IDoor _door;
    private Library.IDisplay _display;

    private string logFile = "logfile.txt"; // Navnet på systemets log-fil

    // Her mangler constructor

    public StationControl() {
        Library.rfidReader x = new Library.rfidReader();

        x.RfidEvent += Test();
        //skal fixes
        x.OnRfidRead(2000);  
    }

    public Library.Notify Test(EventArgs e)
    {
        RfidDetected(2000);

    }

    // Eksempel på event handler for eventet "RFID Detected" fra tilstandsdiagrammet for klassen
    private void RfidDetected(int id)
    {
        switch (_state)
        {
            case LadeskabState.Available:
                // Check for ladeforbindelse
                if (_charger.Connected)
                {
                    _door.LockDoor();
                    _charger.StartCharge();
                    _oldId = id;
                    using (var writer = File.AppendText(logFile))
                    {

                        writer.WriteLine(DateTime.Now + ": Skab låst med RFID: {0}", id);
                    }
                    
                    Console.WriteLine("Skabet er låst og din telefon lades. Brug dit RFID tag til at låse op.");
                    _state = LadeskabState.Locked;
                }
                else
                {
                    _display.StationMessage("xd");
                    Console.WriteLine("Din telefon er ikke ordentlig tilsluttet. Prøv igen.");
                }
                break;
            case LadeskabState.DoorOpen:
                // Ignore
                break;

            case LadeskabState.Locked:
                // Check for correct ID
                if (id == _oldId)
                {
                    _charger.StopCharge();
                    _door.UnlockDoor();
                    using (var writer = File.AppendText(logFile))
                    {
                        writer.WriteLine(DateTime.Now + ": Skab låst op med RFID: {0}", id);
                    }

                    Console.WriteLine("Tag din telefon ud af skabet og luk døren");
                    _state = LadeskabState.Available;
                }
                else
                {
                    Console.WriteLine("Forkert RFID tag");
                }

                break;
        }
    }

    // Her mangler de andre trigger handlere
    // Skal muligvis have en for både open og close per 2.2 i aflevering

    private void DoorState(IDoor _door)
    {
        if (LadeskabState.DoorOpen)
        {
            Console.WriteLine("Tilslut telefon");
        }
        else if (LadeskabState.Available)
        {
            Console.WriteLine("Indlæs RFID");
        }
    }
}

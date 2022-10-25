namespace Library {
    public interface IRfidReader {
        public void OnRfidRead();
    }
    public class rfidReader : IRfidReader
    {
        public void OnRfidRead(int id) {
            if (id != null) {
                console.WriteLine("RFID Read - sending event to station control");
            }
            else {
                console.WriteLine("ERROR: id is faulty");
            }
                //Skal sende alert til stationcontrol som skal afgøre hvorvidt skabet skal låses
        }
    }
}


namespace Library;
public interface IDisplay {
    public void StationMessage(string msg);
    public void ChargingMessage(string msg);
}
public class Display : IDisplay
{
    //Behøver der være forskel på station message og charging message?

    public void StationMessage(string msg) {
        Console.WriteLine("Station Message: \n" + msg);

    }
    public void ChargingMessage(string msg) {
        Console.WriteLine("Charging Message: \n" + msg);
    }
    /*
    void StationMessage()
    {
        
    }
    
    void ChargingMessage()
    {
        
    }

    public void connectPhone()
    {
        Console.WriteLine("connect your phone");
    }

    public void scanRfid()
    {
        Console.WriteLine("Scan your Rfid");
    }

    public void connectionError()
    {
        Console.WriteLine("reconnect your phone");
    }

    public void chargeBoxTaken()
    {
        Console.WriteLine("The box is being used try again later");
    }

    public void RfidErroe()
    {
        Console.WriteLine("scan error try again");
    }

    public void removePhone()
    {
        Console.WriteLine("please remove phone")
    }
    */

}
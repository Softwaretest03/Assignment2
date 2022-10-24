namespace Library;

public class Display
{
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

}
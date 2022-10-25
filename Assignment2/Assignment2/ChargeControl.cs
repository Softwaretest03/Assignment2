namespace Library;
public interface IChargeControl {
    void HandleIsConnected();
    void StartCharge();
    void StopCharge();
}
public class ChargeControl : IChargeControl {
    IUsbCharger _charger;

    
    public void HandleIsConnected() {
        //Should send message to station control and to display  
    }
    public void StartCharge() {
        //Should interface to IUsbCharger to start charge
        _charger.StartCharge();
    }
    public void StopCharge(){
        //Should interface to IUsbCharger to stop charge
        _charger.StopCharge();
    }
}
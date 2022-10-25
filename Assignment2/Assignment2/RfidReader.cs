namespace Library {
    public interface IRfidReader {
        void ReadRfid();
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
        public void ReadRfid(){
            //What should this do
        }
    }
}


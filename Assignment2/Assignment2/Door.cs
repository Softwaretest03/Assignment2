namespace Library
{
    public interface IDoor {
        void LockDoor();
        void UnlockDoor();
    }
    public class Door : IDoor{
        bool locked = false;
        public void LockDoor(){
            Console.WriteLine("Door is locked");
            locked = true;
        }
        public void UnlockDoor(){
            Console.WriteLine("Door is unlocked");
            locked = false;
        }
    }
} 
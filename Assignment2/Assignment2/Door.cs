namespace Library
{
    interface IDoor {
        void LockDoor();
        void UnlockDoor();
    }
    class Door : IDoor{
        bool locked = false;
        public void LockDoor(){
            locked = true;
        }
        public void UnlockDoor(){
            locked = false;
        }
    }
} 
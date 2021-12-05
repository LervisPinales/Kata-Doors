using System;

namespace KataDoor
{
    public class CodeKataDoor
    {
        public bool Open, Closed;
        CodeKataDoor obj;

        public CodeKataDoor(bool Open, bool Closed)
        {
            this.Open = Open;
            this.Closed = Closed;
        }

        public bool Oopen = false;
        public bool closed = false;
        public bool unlocked = false;
        public bool Locked = false;
        
        public bool Door_Open()
        {
            obj = new CodeKataDoor(Oopen, unlocked);

            return true;
        }
        public bool Door_Closed(string key)
        {
            obj = new CodeKataDoor(Oopen, Locked);

            return true;
        }

        public bool Door_Lock(string key)
        {
            if (key == "Lock")
            {
                obj = new CodeKataDoor(closed, Locked);
                return true;
            }
            else
            {
                obj = new CodeKataDoor(Oopen, Locked);
                return true;

            }
        }

        public bool Door_UnLock(string key)
        {
            if (key == "Lock")
            {
                obj = new CodeKataDoor(Oopen, unlocked);
                return true;
            }
            else
            {
                obj = new CodeKataDoor(closed, unlocked);
                return true;

            }
        }
        public bool OpenAndUnlocked(string key)
        {
            if (obj.Door_Open() && obj.Door_UnLock(key) && key == "Unlock")
            {
                Console.WriteLine("Is opend and unlocked");
                obj = new CodeKataDoor(Oopen, unlocked);
                return true;
            }

            else
            {
                Console.WriteLine("The door cannot be opend");

                return false;
            }


        }
        public bool OpenAndLocked(string key)
        {
            if (obj.Door_Open() && obj.Door_Closed(key) && key == "lock")
            {
                Console.WriteLine("The door is open (locked)");
                obj = new CodeKataDoor(Oopen, Locked);
                return true;
            }

            else
            {
                Console.WriteLine("The door could not be opend (locked)");

                return false;
            }


        }

        public bool ClosedAndUnlocked(string key)
        {
            if (obj.Door_Open() && obj.Door_UnLock(key) && key == "Unlock")
            {
                Console.WriteLine("The door is closed (locked)");
                obj = new CodeKataDoor(Oopen, unlocked);
                return true;
            }

            else
            {
                Console.WriteLine("The door could not be closed (Unlocked)");

                return false;
            }


        }

        public bool ClosedAndLocked(string key)
        {
            if (obj.Door_Open() && obj.Door_Lock(key) && key == "lock")
            {
                Console.WriteLine("The door is closed (locked)");
                obj = new CodeKataDoor(Oopen, unlocked);
                return true;
            }

            else
            {
                Console.WriteLine("The door could not be closed (locked)");

                return false;
            }


        }
    }
}

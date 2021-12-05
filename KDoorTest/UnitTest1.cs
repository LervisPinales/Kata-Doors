using KataDoor;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace KDoorTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [Fact]
        public void validate_open()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);
            bool result = obj.Door_Open();
            Assert.IsTrue(result);

        }
        [Fact]
        public void validate_closed()
        {

            CodeKataDoor obj = new CodeKataDoor(true, true);

            bool result = obj.Door_Open();

            Assert.IsTrue(result);

        }
        [Fact]
        public void validate_locked()
        {

            CodeKataDoor obj = new CodeKataDoor(true, true);
            string key = "lock";
            bool result = obj.Door_Closed(key);
            Assert.IsTrue(result);

        }
        [Fact]
        public void validate_Unlocked()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);
            string key = "unlock";
            bool result = obj.Door_Lock(key);
            Assert.IsTrue(result);
        }

        [Fact]
        public void validate_OpenAndUnlocked()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);
            string key = "unlock";
            obj.Door_UnLock(key);
            bool result = obj.Door_UnLock(key);
            Assert.IsTrue(result);
        }
        [Fact]
        public void validate_OpenAndLocked()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);
            string key = "lock";
            obj.Door_Lock(key);
            bool result = obj.OpenAndLocked(key);
            Assert.IsTrue(result);

        }
        [Fact]

        public void validate_ClosedAndUnlocked()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);

            string key = "Unlock";

            obj.Door_Lock(key);

            bool result = obj.ClosedAndUnlocked(key);

            Assert.IsTrue(result);
        }

        [Fact]
        public void validate_ClosedAndLocked()
        {
            CodeKataDoor obj = new CodeKataDoor(true, true);
            string key = "lock";
            obj.Door_Lock(key);
            bool result = obj.ClosedAndLocked(key);
            Assert.IsTrue(result);
        }
    }
}

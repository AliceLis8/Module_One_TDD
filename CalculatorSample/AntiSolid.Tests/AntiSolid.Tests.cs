using AntiSolid.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AntiSolid.Tests
{
    [TestClass]
    public class ChillGuyTest
    {
        [TestMethod]
        public void Guy_Has_Recieved_BigBag_Of_Happiness()
        {
            ChillGuy guy = new ChillGuy();
            guy.RecieveBigBag();
            Assert.IsTrue(guy.HasEmotion);
            Assert.AreEqual(new Life(), guy.Emotion);
        }

        [TestMethod]
        public void Guy_Has_Recieved_A_Lot_Of_Information()
        {
            ChillGuy guy = new ChillGuy();
            guy.AddSmart();
            Assert.IsTrue(guy.HasEmotion);
            Assert.AreEqual(new Power(), guy.Emotion);
        }
    }
}

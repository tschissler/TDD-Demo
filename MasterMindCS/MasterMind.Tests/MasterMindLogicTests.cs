using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MasterMind.App;

namespace MasterMind.Tests
{
    [TestClass]
    public class MasterMindLogicTests
    {
        [TestMethod]
        public void ReceiveCode_ShouldReturnFourCharactersWithinLevelRange()
        {
            int level = 3;

            string code = MasterMindLogic.ReceiveCode(level);

            Assert.AreEqual(4, code.Length);
            Assert.IsTrue(code.All(c => c >= 'A' && c <= 'E'));
        }
    }
}

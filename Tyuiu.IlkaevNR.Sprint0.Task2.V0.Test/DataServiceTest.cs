using Tyuiu.IlkaevNR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.IlkaevNR.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Наиль";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Наиль", res);
        }
    }
}

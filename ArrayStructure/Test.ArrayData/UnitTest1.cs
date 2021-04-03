using ArrayStructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.ArrayData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddSingleElementShouldReturn1()
        {
            ArrayList<int> arr = new ArrayList<int>();

            arr.Add(1);

            Assert.AreEqual(1, arr.IndexCount);
        }
    }
}

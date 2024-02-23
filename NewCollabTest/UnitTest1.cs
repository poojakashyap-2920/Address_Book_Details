namespace NewCollabTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int res = newcollab.add.addition(2, 5);
            int expected = 76;
            Assert.AreEqual(expected, res);
        }
    }
}
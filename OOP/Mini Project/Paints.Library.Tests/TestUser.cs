namespace Paints.Library.Tests
{
    [TestClass]
    public sealed class TestUser
    {
        [TestMethod]
        public void TestName()
        {
            var expectedValue = "Test User";
            var obj = new User(expectedValue, Guid.NewGuid());

            Assert.AreEqual(expectedValue, obj.Name, "The Name property should return the value passed in the constructor.");
        }

        [TestMethod]
        public void TestUser_Id()
        {
            var expectedValue = Guid.NewGuid();
            var obj = new User("Test User", expectedValue);

            Assert.AreEqual(expectedValue, obj.Id, "The Id property should return the value passed in the constructor.");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestId_Empty()
        {
            var obj = new User("Test User", Guid.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestName_Empty()
        {
            var obj = new User("", Guid.NewGuid());
        }


    }
}

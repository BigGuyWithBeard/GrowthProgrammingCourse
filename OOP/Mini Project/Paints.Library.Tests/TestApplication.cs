namespace Paints.Library.Tests
{
    [TestClass]
    public sealed class TestApplication
    {

        [TestMethod]
        public void TestItems_Get()
        {
            var app = new Application();
            var result = app.Items;

            Assert.IsNotNull(result, "result is null");
            Assert.IsInstanceOfType(result,typeof( ItemController));

        }


        [TestMethod]
        public void TestUsers_Get()
        {
            var app = new Application();
            var result = app.Users;

            Assert.IsNotNull(result, "result is null");
            Assert.IsInstanceOfType(result, typeof(UserController));
        }

        [TestMethod]
        public void TestUsers_Unique()
        {
            Assert.Fail(); // This test is not implemented yet. It should check that the UserController does not allow duplicate users.
        }

        [TestMethod]
        public void TestImtes_Unique()
        {
           Assert.Fail(); // This test is not implemented yet. It should check that the ItemController does not allow duplicate items.
        }
    }
}

namespace Paints.Library.Tests
{
    [TestClass]
    public sealed class TestUserController
    {
   



        private static List<IUser> GetTestData()
        {
            return new List<IUser>
            {
                new User("user 1", Guid.Parse("00000001-0000-0000-0000-000000000000")),
                new User ("user two",Guid.Parse("00000002-0000-0000-0000-000000000000")),
                new User( "user 3", Guid.Parse("00000003-0000-0000-0000-000000000000"))
            };
        }

        [TestMethod]
        public void TestFind_EmptyTerms()
        {

            var obj = new UserController(GetTestData());

            var searchTerms = "";
            var results = obj.Find(searchTerms);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(List<IUser>));
            Assert.AreEqual(0, results.Count, "Results should be empty when no items are present.");

        }

        [TestMethod]
        public void TestFind_NotEmptyTerms()
        {

            var obj = new UserController(GetTestData());

            var searchTerms = "foo foo foo";
            var results = obj.Find(searchTerms);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(List<IUser>));
            Assert.AreEqual(0, results.Count, "Results should be empty when no items are present.");

        }

    }
}

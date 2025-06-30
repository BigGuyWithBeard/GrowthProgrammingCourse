using System.Xml.Schema;

namespace Paints.Library.Tests
{
    [TestClass]
    public sealed class TestItemController
    {

    
        private static List<IItem> GetTestData()
        {
            return new List<IItem>
            {
                new PaintItem(PaintTypes.Acrylic, "Product Range 1","Red","Manufacturer"),
                new SprayItem (PaintTypes.Oil,"Product Range 1", "Red,Green","Manufacturer"),
                new TuftItem( PaintTypes.Enamel, "Product Range 2","Green","Manufacturer B" )
            };
        }

        [TestMethod]
        public void TestFind_EmptyTerms() { 
        
            var obj = new ItemController(GetTestData());

            var searchTerms = "";
            var results = obj.Find(searchTerms);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(List<IItem>));
            Assert.AreEqual (0, results.Count, "Results should be empty when no items are present.");

        }

        [TestMethod]
        public void TestFind_NotEmptyTerms()
        {

            var obj = new ItemController(GetTestData());

            var searchTerms = "red blue";
            var results = obj.Find(searchTerms);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results, typeof(List<IItem>));
            Assert.AreEqual(0, results.Count, "Results should be empty when no items are present.");

        }
    }
}

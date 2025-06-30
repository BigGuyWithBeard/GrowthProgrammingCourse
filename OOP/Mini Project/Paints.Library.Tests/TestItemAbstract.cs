using Paints.Library;
using System.Runtime.CompilerServices;


namespace Paints.Library.Tests
{
    class TestItem : ItemAbstract
    {
        public TestItem(PaintTypes paintType, string productRange, string colourRange, string manufacturer) : base(paintType, productRange, colourRange, manufacturer)
        {
        }
    }


    /// <summary>
    /// here we will test the features of the abstract class.
    /// as we connot directly instantiate an abstract class, we will create a concrete class that inherits from it.
    /// </summary>
    [TestClass]
    public sealed class TestItemAbstract
    {
        [TestMethod]
        public void TestPaintType_Invalid()
        {
            // not sure how to test this - how do we supply an invalid enum value?
            //throw new NotImplementedException();
            Assert.Inconclusive();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestManufacturer_Empty()
        {


            var obj = new TestItem(PaintTypes.Acrylic, "Product Range", "Red", string.Empty);
            // this should throw an exception because the colour range is empty
            var colourRange = obj.ColourRange;


        }


   

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestColourRange_Empty()
        {
          var obj = new TestItem(PaintTypes.Acrylic, "Product Range", string.Empty,"Manufacturer");
            // this should throw an exception because the colour range is empty
            var colourRange = obj.ColourRange;
        }

        [TestMethod]
        public void TestPaintType_Get()
        {
            // should return the same value as the one passed in the constructor
            var x = new TestItem(PaintTypes.Acrylic,"Product range", "Red", "Manufacturer");

            Assert.AreEqual(PaintTypes.Acrylic, x.PaintType);
            
        }

        [TestMethod]
        public void TestManufacturer_Get()
        {
            string expectedValue = "Test Manufacturer";
            // should return the same value as the one passed in the constructor
            var x = new TestItem(PaintTypes.Acrylic, "Product Range", "Red", expectedValue);

            Assert.AreEqual(expectedValue, x.Manufacturer);

        }

        [TestMethod]
        public void TestProductRange_Get()
        {

            var expectedValue = "Test Range";

            // should return the same value as the one passed in the constructor
            var x = new TestItem(PaintTypes.Acrylic, expectedValue, "Red","Manufacturer");

            Assert.AreEqual(expectedValue, x.ProductRange);

        }



        [TestMethod]
        public void TestColourGroup_Get()
        {
            var expectedValue = "Red";

            // should return the same value as the one passed in the constructor
            var x = new TestItem(PaintTypes.Acrylic, "Product Range", expectedValue, "Manufacturer");

            Assert.IsInstanceOfType(x.ColourRange, typeof(string));
            Assert.AreEqual(expectedValue, x.ColourRange);

        }
    }
}

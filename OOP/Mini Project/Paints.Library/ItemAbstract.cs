using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{


    public class ItemAbstract : IItem
    {
        public ItemAbstract(PaintTypes paintType, string productRange, string colourRange, string manufacturer)
        {
            if (string.IsNullOrWhiteSpace(productRange))
            {
                throw new ArgumentException("Product range cannot be null or empty.", nameof(productRange));
            }
            if (!Enum.IsDefined(typeof(PaintTypes), paintType))
            {
                throw new ArgumentOutOfRangeException(nameof(paintType), "Invalid paint type specified.");
            }
            if(string.IsNullOrWhiteSpace(colourRange))
            {
                throw new ArgumentException("Colour range cannot be null or empty.", nameof(colourRange));
            }
            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                throw new ArgumentException("Manufacturer cannot be null or empty.", nameof(manufacturer));
            }
            PaintType = paintType;
            ProductRange = productRange;
            ColourRange = colourRange;
            Manufacturer = manufacturer;
        }

        public PaintTypes PaintType { get; }

        public string ProductRange { get; }
        public string ColourRange { get; }  

        public string Manufacturer { get; }
    }
}

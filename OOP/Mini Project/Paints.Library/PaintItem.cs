using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    public class PaintItem : ItemAbstract
    {
        public PaintItem(PaintTypes paintType, string productRange, string colourRange, string manufacturer) : base(paintType, productRange, colourRange, manufacturer)
        {
        }
    }
}

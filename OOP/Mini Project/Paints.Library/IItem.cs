using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    public interface IItem
    {
        PaintTypes PaintType { get; }
        String ProductRange { get; }
        string ColourRange { get; }
        string Manufacturer { get; }
    }
}

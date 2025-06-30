using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    public class ItemController
    {

        private List<IItem> _items;

        public ItemController(List<IItem> items)
        {
            _items = items;
        }

        public List<IItem> Find(string searchTerms)
        {
            if (string.IsNullOrWhiteSpace(searchTerms))
            {
                return new List<IItem>();
            }
            var terms = searchTerms.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return _items.Where(item => terms.Any(term => item.PaintType.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))).ToList();
        }   
    }
}

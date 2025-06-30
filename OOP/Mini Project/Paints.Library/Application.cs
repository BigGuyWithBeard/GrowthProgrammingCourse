using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    /// <summary>
    /// main application class. holds and controls references to objects.
    /// </summary>
    public class Application
    {

        // variables to hold objects in application
        // private so ensure no other object overwrites or replaces them.
        // data in the variables should be accessed through controller methods.
        private List<IUser> _users { get; }
        private List<IItem> _items { get; }
        public ItemController Items { get; }
        public UserController Users { get; }


        public Application()
        {
            _users = new List<IUser>();
            _items = new List<IItem>(); 
            Items = new ItemController(_items);
            Users = new UserController(_users);
        }
    }
}

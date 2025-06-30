using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    public class UserController
    {

        private List<IUser> _users;

        public UserController(List<IUser> users)
        {
            _users = users;
        }

        public List<IUser> Find(string searchTerms)
        {
            if (string.IsNullOrWhiteSpace(searchTerms))
            {
                return new List<IUser>();
            }
            var terms = searchTerms.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            return _users.Where(item => terms.Any(term => item.Name.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))).ToList();
        }
    }
}

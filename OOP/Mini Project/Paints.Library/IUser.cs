﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paints.Library
{
    public interface IUser
    {

        public string Name { get;  }
        public Guid Id { get;  }    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Models
{
    //This is an abstract class because this class cannot be instantiated, it only can be inherited.
    //All other entities will inherit from this class.
    //The difference between an abstract class and an interface, is that an abstract class can have logic,
    //and the interface it’s just a contract which specifies what are the methods or properties.
    public abstract class Entity
    {
        public int id { get; set; }
    }
}

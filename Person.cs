using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraAssignment3
{
    public abstract class Person
    {
        protected string _name;

        protected int _id;

        public virtual int Id { get; set; }
        public abstract void Name(string name);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Aggregate // this is the aggregate class
    {
        public List<string> Roster;

        public abstract Iterator createIterator();
    }
}

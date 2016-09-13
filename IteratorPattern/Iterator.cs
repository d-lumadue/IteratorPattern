using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Iterator //this is the iterator class
    {
        public abstract object first();
        public abstract object next();
        public abstract bool isDone();
        public abstract object currentItem();
    }
}

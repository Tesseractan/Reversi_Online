using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversi_Online
{
    public class Pair
    {
        private object a;
        private object b;

        public Pair(object a, object b)
        {
            this.a = a;
            this.b = b;
        }
        public Pair(ref object a, ref object b) : this(a, b) { }

        public void Swap()
        {
            object temporary = this.a;
            this.a = this.b;
            this.b = temporary;
        }

        public bool HasSameTypes
        {
            get { return this.a.GetType() == this.b.GetType(); }
        }

        public object A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public object B
        {
            get { return this.b; }
            set { this.b = value; }
        }
    }
    public class Pair<T>
    {
        private T a;
        private T b;

        public Pair(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public Pair(ref T a, ref T b) : this(a, b) { }

        public T A
        {
            get { return this.a; }
            set { this.a = value; }
        }
        public T B
        {
            get { return this.b; }
            set { this.b = value; }
        }
    }
}

using Open_Closed_Principle.Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.After
{
    abstract class Question
    {
        public string Tilte { get; set; }
        public int Mark { get; set; }


        public abstract void print();
    }
}

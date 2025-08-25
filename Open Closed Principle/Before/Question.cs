using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
{
        internal class Question
        {
            public string Tilte { get; set; }
            public int Mark { get; set; }
            public QuestionType QuestionType { get; set; }

            public List<string> Choise { get; set; } = new List<string>();
        }
}

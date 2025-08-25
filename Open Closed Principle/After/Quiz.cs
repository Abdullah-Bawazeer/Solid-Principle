using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.After
{
    internal class Quiz
    {
        List<Question> Questions { get; }

        public Quiz(List<Question> questions)
        {
            Questions = questions;
        }

        public void print()
        {
            foreach (var q in Questions)
            {
                Console.WriteLine($"{q.Tilte} [{q.Mark}]");
                q.print();
                Console.WriteLine("\n\n");
            }   
        }
    }
}

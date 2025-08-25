using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
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
                switch (q.QuestionType)
                {
                    case QuestionType.WH:
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("---------------------------------");
                        break;
                    case QuestionType.TRUEFALSE:
                        Console.WriteLine("1. T");
                        Console.WriteLine("2. F"); 
                        break;
                    case QuestionType.MULTIPLECHOICE:
                        foreach (var choise in q.Choise)
                        {
                            Console.WriteLine($"{choise}");
                        }
                        break;
                    default:
                        break;
                }
                Console.WriteLine("\n\n");
            }   
        }
    }
}

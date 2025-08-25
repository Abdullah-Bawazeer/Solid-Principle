using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.After
{
    internal class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>()
            {
                new WHQuestion()
                {
                    Tilte ="what is the four pillars in OOP?",
                   
                    Mark = 8
                },
                new MultipleChoiseQuestion()
                {
                    Tilte ="whitch of the follwoing are value type?",
                    Mark = 6,
                    Choise  = new List<string>()
                    {
                        "A:integer",
                        "B:Array",
                        "C:Single",
                        "D:String",
                        "E:Long",
                    }
                },
                new TRUEFALSEQuestion()
                {
                    Tilte ="Earth is bigger thn sun?",
                    Mark = 4
                },
                new MatchQuestion()
                {
                    Tilte ="match column 1 value with single choice from 2 nd column?",
                    Mark = 10,
                    row  = new Dictionary<string ,string>()
                    {
                        {"A","b"},
                        {"C","M"},
                        {"L","Q"},
                        {"T","P"},
                        {"AX","Z"}   
                    }
                },
            };
        }
    }
}

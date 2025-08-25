using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
{
    internal class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>()
            {
                new Question()
                {
                    Tilte ="what is the four pillars in OOP?",
                    QuestionType = QuestionType.WH,
                    Mark = 8
                },
                new Question()
                {
                    Tilte ="whitch of the follwoing are value type?",
                    QuestionType = QuestionType.MULTIPLECHOICE,
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
                 new Question()
                {
                    Tilte ="Earth is bigger thn sun?",
                    QuestionType = QuestionType.TRUEFALSE,
                    Mark = 4
                },
            };
        }
    }
}

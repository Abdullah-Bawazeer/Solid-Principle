namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var Quiz = new Before.Quiz(Before.QuestionBank.Generate());
            //Quiz.print();

            var Quiz = new After.Quiz(After.QuestionBank.Generate());
            Quiz.print();
            Console.ReadKey();
        }
    }
}

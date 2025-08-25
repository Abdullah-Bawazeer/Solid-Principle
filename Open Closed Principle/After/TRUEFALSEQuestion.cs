namespace Open_Closed_Principle.After
{
    class TRUEFALSEQuestion : Question
    {
        public override void print()
        {
            Console.WriteLine($"{Tilte} [{Mark}]");
            Console.WriteLine("1.  true");
            Console.WriteLine("2.  false"); 
        }
    }
}

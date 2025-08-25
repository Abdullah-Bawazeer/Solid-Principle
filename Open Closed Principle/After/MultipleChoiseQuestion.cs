namespace Open_Closed_Principle.After
{
    class MultipleChoiseQuestion : Question
    {
        public List<string> Choise { get; set; } = new List<string>();
        public override void print()
        {
            Console.WriteLine($"{Tilte} [{Mark}]");
            foreach (var choise in Choise)
            {
                Console.WriteLine($"{choise}");
            }

        }
    }
}

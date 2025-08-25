namespace Open_Closed_Principle.After
{
    class MatchQuestion : Question
    {
        public Dictionary<string ,string> row { get; set; } = new Dictionary<string, string>();
        public override void print()
        {
            Console.WriteLine($"{Tilte} [{Mark}]");
            foreach (var item in row)
            {
                Console.WriteLine($"key {item.Key} ---------- value  {item.Value}");
            }
           
        }
    }
}

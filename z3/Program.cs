 namespace z3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пример");
            PlantSpecies dem = new PlantSpecies("(название растения)","(место обитания растения)","(оценка популярности растения).");
            InfoObj.Info<PlantSpecies>(dem);
            Console.WriteLine("__________");
            Weth WethList = new Weth();
            Dictionary<string, string> Plant = new Dictionary<string, string>(3);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Введите название растения");
                string w = Console.ReadLine();
                Console.WriteLine("Введите место обитания");
                string g = Console.ReadLine();
                Console.WriteLine("Введите вид растения");
                string t = Console.ReadLine();
                WethList.Add(new PlantSpecies(w, g, t));
            }
            Console.WriteLine("============");
            foreach (KeyValuePair<string,string> keyValue in Plant)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine("============");
            foreach (PlantSpecies x in WethList)
                x.PrintData();
            WethList.RemoveAt(1);
            Console.WriteLine("============");
            Weth c1 = (Weth)WethList.Clone();
            foreach (PlantSpecies x in c1) x.PrintData();
            Console.ReadLine();
        }
    }
}
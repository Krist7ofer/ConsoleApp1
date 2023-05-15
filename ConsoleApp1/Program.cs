namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - TupleSix(); 2 - TupleWithValues(); 3 - WithSortedList().");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("-----------------");
                    TupleSix();
                    break;

                case 2:
                    Console.WriteLine("-----------------");
                    TupleWithValues();
                    break;

                case 3:
                    Console.WriteLine("-----------------");
                    WithSortedList();
                    break;

                default:
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("Valisite vale juhtumi.");
                    break;
            }
        }
        static void TupleSix()
        {
            var values = Tuple.Create(1, 2,3,4,5,6);
            TupleParam(values);
        }
        static void TupleParam(Tuple<int, int, int, int, int, int> values)
        {
            Console.WriteLine(values.ToString());
        }           
        static void TupleWithValues()
        {
            ValueTuple<int, string, string> valueTuple = (69, "string", "string2");
            Console.WriteLine(valueTuple.ToString());
        }
        static void WithSortedList()
        {
            SortedList<int, string> numberNames = new SortedList<int, string>();
            numberNames.Add(17, "Seitseteist");
            numberNames.Add(15, "Viisteist");
            numberNames.Add(5, "Viis");
            numberNames.Add(7, "Seitse");
            numberNames.Add(9, "Üheksa");
            //Sorteerib numbrid kasvavas järjekorras.
            foreach (var kvp in numberNames)
            {
                Console.WriteLine($"{kvp.Key}, {kvp.Value}");
            }
            
        }
    }
}
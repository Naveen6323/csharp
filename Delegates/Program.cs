namespace Delegates
{
    public delegate void PrintMessage(string msg);

    public delegate void Menu();
    internal class Delegates
    {
        static void PrintToConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void PrintToFile(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void ShowDate()
        {
            Console.WriteLine($"current date = {DateTime.Now.ToShortDateString()}");
        }
        public static void ShowTime()
        {
            Console.WriteLine($"current Time = {DateTime.Now.ToLongTimeString()}");
        }

        public static void Exit()
        {
            Console.WriteLine("exiting the application");
        }
        public static void Main(string[] args)
        {

        //PrintMessage printMessageDel = PrintToConsole;
        //    printMessageDel += PrintToFile;
        //    printMessageDel("heelo world");
            Dictionary<string, Menu> menu = new Dictionary<string, Menu>
            {
                { "1", ShowDate },
                { "2", ShowTime },
                { "3", Exit }
            };
            //while (true)
            //{
            //    Console.WriteLine("menu");
            //    Console.WriteLine("1.shodate");
            //    Console.WriteLine("2.showtimw");
            //    Console.WriteLine("3.exit");
            //    Console.WriteLine("enter ur choice");
            //    string choice = Console.ReadLine();
            //    if (menu.ContainsKey(choice))
            //    {
            //        menu[choice]();
            //        if (choice == "3") break;

            //    }
            //    else
            //    {
            //        Console.WriteLine("invalid choice try again");
            //    }
            //}
            Calc.Calculate c = Calc.SubNums;
            c +=Calc.AddNums;
            c(5, 3);

        }
    }


    class Calc
    {
        public delegate void Calculate(int a, int b);

        public static void AddNums(int a, int b)
        {
            Console.WriteLine("sum: "+(a+b));
        }

        public static void SubNums(int a, int b)
        {
            Console.WriteLine("sub : "+(a-b));
        }
        public static void MulNums(int a, int b)
        {
            Console.WriteLine("Mul : " + (a * b));
        }

    }
}


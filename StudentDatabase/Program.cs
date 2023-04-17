namespace StudentDatabase
{
    public class Program
    {
        public static void Main()
        {
            bool goOn = true;
            string[] name = { "Clayton Burch", "Anoushka Li", "Michaela Blankenship", "Brooke Connolly", "Tillie Leblanc", "Abby Montgomery", "Philip Barr", "Russell Miles", "Aayan Burton", "Rahul Thompson" };
            string[] hometown= { "Detroit", "Grand Rapids", "Warren", "Sterling Heights", "Ann Arbor", "Lansing", "Livonia", "Macomb", "Canton" , "Romeo" };
            string[] favoriteFood= { "Chips", "Donuts", "Ice Cream", "Chicken Tenders", "Smoothies", "Pizza", "Oreos", "French Fries", "Hot Dogs", "Hamburgers" };
            
            bool list = AskForList();
            if (list)
            {
                PrintArray(name);
            }

            do
            {
                int nameInput = SelectIndex(name, "name");
                Console.WriteLine( "Student "+ nameInput + " is " + name[nameInput - 1]);
                string infoInput = SelectArray();
                if (infoInput == "home")
                {
                    Console.WriteLine(name[nameInput - 1] + " is from " + hometown[nameInput - 1]);
                }
                else
                {
                    Console.WriteLine(name[nameInput - 1] + "'s favorite food is " + favoriteFood[nameInput - 1]);
                }
                goOn = Continue();
            }while(goOn);
        }
        public static int SelectIndex(string[] arr, string arrName)
        {
            Console.WriteLine($"Choose a number between 1-"+arr.Length);
            int input = ForceIntOutput();
            if (input<= 0 || input > arr.Length)
            {
                Console.WriteLine("Number outside of range, try again.");
                return SelectIndex(arr, arrName);
            }
            else
            {
                return input;
            }
        }
        public static int ForceIntOutput()
        {
            int output = 0;

            while(!int.TryParse(Console.ReadLine(), out output))
            {
                Console.WriteLine("Please input a valid number: ");
                return ForceIntOutput();
            }
            return output;
        }
        public static string SelectArray()
        {
            Console.WriteLine("What would you like to know? Enter \"hometown\" or \"favorite food\":");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "favorite food" || input == "favorite" || input == "food")
            {
                return "food";
            }
            else if (input == "hometown" || input == "home" || input == "town")
            {
                return "home";
            }
            else
            {
                return SelectArray();
            }
        }
        public static void PrintArray(string[] arr)
        { 
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine((i+1)+ " " + arr[i]);
            }
        }
        public static bool AskForList()
        {
            Console.WriteLine("Welcome! Would you like a list of students? Enter 'y' or 'n': ");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                return AskForList();
            }
        }
        public static bool Continue()
        {
            Console.WriteLine("Would you like to learn about another student? Enter 'y' or 'n': ");
            string input = Console.ReadLine().ToLower().Trim();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                return Continue();
            }
        }
    }
}
namespace Assignment_5_Part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Raine DeVries
            double earthWeight;
            string planetChoice;
            
            Console.WriteLine("Please enter your current earth weight");
            double.TryParse(Console.ReadLine(), out earthWeight);

            Console.WriteLine("I have the info about the followwing planets ");
            Console.WriteLine("1. Venus 2. Mars 3. Jupiter");
            Console.WriteLine("4. Saturn 5. Uranus 6. Neptune");
            Console.WriteLine("Which planet are you visiting?");
            planetChoice = Console.ReadLine();


            if (planetChoice == "1")                                                                    
            {
                Console.WriteLine("You've chosin Venus, your weight is " + (earthWeight * 0.78));
            }
            if (planetChoice == "2")
            {
                Console.WriteLine("You've chosin Mars, your weight is " + (earthWeight * 0.39));
            }
            if (planetChoice == "3")
            {
                Console.WriteLine("You've chosin Jupiter, your weight is " + (earthWeight * 2.65));
            }
            if (planetChoice == "4")
            {
                Console.WriteLine("You've chosin Saturn, your weight is " + (earthWeight * 1.17));
            }
            if (planetChoice == "5")
            {
                Console.WriteLine("You've chosin Uranus, your weight is" + (earthWeight * 1.05));
            }
            if (planetChoice == "6")
            {
                Console.WriteLine("You've chosin Neptune, your weight is" + (earthWeight * 1.23));
            }

            Console.ReadLine();
            Console.Clear();
           
        }
    }
}

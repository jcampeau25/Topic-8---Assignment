using System.Runtime.InteropServices;

namespace Topic_8___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading in Colours
            List <string> colours = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue", "Purple" };
            Random generator = new Random();
            int colour = generator.Next(colours.Count);
            Console.WriteLine(colours[colour]);
            Console.WriteLine();



            // Random Numbers
            int max, min, numberAmount, countedNumber, count, changeNumber;
            changeNumber = 0;
            count = 0;
            

            Console.WriteLine("Please enter the amount of numbers you want to generate ");
            while(!Int32.TryParse(Console.ReadLine(), out numberAmount))
                Console.WriteLine("Invalid input");
            Console.WriteLine("Please enter the minimum value of the numbers you want generated");
            while(!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Invalid input");
            Console.WriteLine("Please enter the maximum value of the numbers you want generated");
            while (!Int32.TryParse(Console.ReadLine(), out max) || max <= min)
                Console.WriteLine("Invalid input");
            max ++;
            List<int> numbers1 = new List<int> { generator.Next(min, max + 1) };
            for (int i = 0; i <= numberAmount; i++)
               numbers1.Add(generator.Next(min, max));
            Console.WriteLine(string.Join(",", numbers1));

            Console.WriteLine();
            Console.WriteLine("Please choose a number within the range and I will count how many times that number is generated");
            while (!Int32.TryParse(Console.ReadLine(), out countedNumber))
                Console.WriteLine("Invalid input");



            List<int> numbers2 = new List<int> { generator.Next(min, max + 1) };
            for (int i = 0; i <= numberAmount; i++)
                numbers2.Add(generator.Next(min, max));

            for (int i = 0; i < numbers2.Count; i++)
            {
                if (numbers2[i] == countedNumber)
                {
                    count++;
                }
            }


            Console.WriteLine();
            Console.WriteLine(string.Join(",", numbers2));
            Console.WriteLine(countedNumber + " appeared " + count + " times");
            Console.WriteLine();

            Console.WriteLine("Please enter a number and I will replace that number with 0");
            while (!Int32.TryParse(Console.ReadLine(), out changeNumber))
                Console.WriteLine("Invalid Input");

            List<int> numbers3 = new List<int> { generator.Next(min, max + 1) };
            for (int i = 0; i <= numberAmount; i++)
                numbers3.Add(generator.Next(min, max));
            
            for (int i = 0; i < numbers3.Count; i++)
            {
                if (numbers3[i] == changeNumber)
                {
                    numbers3[i] = 0;
                }
            }

            Console.WriteLine(string.Join(",", numbers3));
            for (int i = 0; i < numbers3.Count; i++)
            {
                numbers3[i] = 0;
            }
            Console.WriteLine("Press enter to reset");
            Console.ReadLine();
            Console.WriteLine(string.Join(",", numbers3));

        }
    }
}

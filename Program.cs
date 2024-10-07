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


            // Random Numbers
        }
    }
}

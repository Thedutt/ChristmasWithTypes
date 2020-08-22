using System;

namespace ChristmasWithTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;
            string firstpresent = "PS5";
            string secondpresent = "Brakes";
            string thirdpresent = "Iphone";
            //Done set Santa's name to Kris Kringle
            string xmasSanta = "Kris Kringle";

            //Done Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{firstpresent, secondpresent, thirdpresent}; 

            //Done Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"{present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmasSanta}");

            String auburnFanatic = "War Eagle, bama sucks, i dont understand how science works";

            Console.WriteLine("December is 4 months away");

            Console.WriteLine(auburnFanatic);

            string carLine = ("2004 silver corvette");
            Console.WriteLine(carLine);
        }
    }
}

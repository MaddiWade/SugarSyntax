using System;

namespace SugarSyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var answer = 12;
            string response = (answer < 9) ? "is less than nine" : "Greater then or equal to 9";
            Console.WriteLine(response);

            // it was bothering me there was nothing on my command prompt lol
          

        }
    }
}

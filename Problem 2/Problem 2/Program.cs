using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students =
                new Dictionary<int, string>();
            //Adding to a dictionary
            students.Add(1234567, "Apisada Sompong");
            //students.Add(1234567, "AA");
            //checking if a key exist
            if(students.ContainsKey(1234567))
            {
                Console.WriteLine($"{1234567} already exists");
                students[1234567] = "aa";
            }
            else
            {
                Console.WriteLine("Key doesn't exist");
            }
            //Getting a value
            Console.WriteLine(students[1234567]);
            Console.ReadKey();
    }
}
]
using System.Reflection;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddTwoNumber addTwoNumber = new AddTwoNumber();
            var result = addTwoNumber.Add(12, 13);
            Console.WriteLine(result);
            Console.WriteLine("---------");

            var result1 = addTwoNumber.Add(12.25m, 12.75m);
            Console.WriteLine(result1);
            Console.WriteLine("------");

            var result2 = addTwoNumber.Add("hello ", "world");
            Console.WriteLine(result2);


            
        }
    }
}
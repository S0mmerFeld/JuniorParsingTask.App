using System;
using JuniorParsingTask;

namespace JuniorParsingTask.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = TreeService.Create();

            Node itemres;

            Console.WriteLine(tree.TryGetNode("parsing", out itemres));
            Console.ReadKey();
        }
    }
}

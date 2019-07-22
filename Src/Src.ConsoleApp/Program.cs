using System;

namespace Src.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Common.Tools.GetSiblingFolderPath("Log");
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}

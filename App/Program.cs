using System;
using Classes;

namespace App
{
    class Program
    {
        private static void Main(string[] args)
        {
            var writer = new ConsoleWriter();
            var controller = new Controller(writer);
            controller.Run();
        }
    }
}

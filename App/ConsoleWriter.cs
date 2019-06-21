using System;

namespace App
{
    public class ConsoleWriter : IOutput
    {
        public void Write(string data)
        {
            Console.WriteLine(data);
        }
    }
}
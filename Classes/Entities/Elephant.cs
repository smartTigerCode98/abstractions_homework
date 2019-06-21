using System;
using Classes.Basic;

namespace Classes.Entities
{
    public class Elephant : Animal
    {
        public Elephant(string name, string color) : base(name, color) {}

        public override string Voice()
        {
            return "uuuuu";
        }
    }
}
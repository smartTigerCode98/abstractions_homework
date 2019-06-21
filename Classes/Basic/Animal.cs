using Classes.Interfaces;

namespace Classes.Basic
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        protected Animal(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public abstract string Voice();
    }
}
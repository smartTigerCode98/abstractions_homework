using Classes.Basic;

namespace Classes.Entities
{
    public class Tiger : Animal
    {
        public Tiger(string name, string color) : base(name, color) {}

        public override string Voice()
        {
            return "rrrrrr";
        }
    }
}
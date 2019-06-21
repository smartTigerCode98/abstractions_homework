using Classes.Basic;

namespace Classes.Entities
{
    public class Monkey : Animal
    {
        public Monkey(string name, string color) : base(name, color) {}

        public override string Voice()
        {
            return "uauauua";
        }
    }
}
using Classes.Basic;
using Classes.Interfaces;

namespace Classes.Entities
{
    public class Dog : Animal, IPet
    {
        public bool IsVaccinated { get; set; }

        public Dog(string name, string color, bool isVaccinated) : base(name, color)
        {
            IsVaccinated = isVaccinated;
        }

        public override string Voice()
        {
            return "guf-guf";
        }
    }
}
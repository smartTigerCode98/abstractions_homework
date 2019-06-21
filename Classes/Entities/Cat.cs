using Classes.Basic;
using Classes.Interfaces;

namespace Classes.Entities
{
    public class Cat : Animal, IPet
    {
        public bool IsVaccinated { get; set; }
        
        public Cat(string name, string color, bool isVaccinated) : base(name, color)
        {
            IsVaccinated = isVaccinated;
        }

        public override string Voice()
        {
            return "myau";
        }
    }
}
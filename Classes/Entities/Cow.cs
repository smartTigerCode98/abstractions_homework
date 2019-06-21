using Classes.Basic;
using Classes.Interfaces;

namespace Classes.Entities
{
    public class Cow : Animal, IPet
    {
        public bool IsVaccinated { get; set; }
        
        public Cow(string name, string color, bool isVaccinated) : base(name, color)
        {
            IsVaccinated = isVaccinated;
        }

        public override string Voice()
        {
            return "mu-mu";
        }
        
    }
}
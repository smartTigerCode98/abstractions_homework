using System.Collections.Generic;
using System.Linq;
using Classes.Basic;
using Classes.Entities;
using Classes.Interfaces;

namespace App
{
    public class Controller
    {
        private readonly IOutput _output;

        public Controller(IOutput output)
        {
            _output = output;
        }
        
        public void Run()
        {
            var animals = new List<Animal>
            {
                new Cat("Jysik", "white-gray", false),
                new Dog("Rex", "black", true),
                new Cow("Masha", "white", true),
                new Elephant("Arnold", "blue"),
                new Monkey("Shyrik", "black"),
                new Tiger("Yuri", "black")
            };
            
            var listenerVoice = new ListenerVoice(_output);
            listenerVoice.Voice<Cow>(animals.OfType<IPet>());
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Classes.Basic;
using Classes.Entities;
using Classes.Interfaces;

namespace App
{
    public class Controller
    {
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
            
            var writer = new ConsoleWriter();
            var listenerVoice = new ListenerVoice(writer);
            listenerVoice.Voice<Cow>(animals.OfType<IPet>());
        }
    }
}
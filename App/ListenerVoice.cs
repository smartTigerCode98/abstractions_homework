using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Interfaces;

namespace App
{
    public class ListenerVoice : IHearVoice
    {
        private readonly IOutput _output;

        public ListenerVoice(IOutput iOutput)
        {
            _output = iOutput;
        }
        
        public void Voice<T>(IEnumerable<IPet> animals) where T : IPet
        {
            var certainAnimals = animals.OfType<T>();
            foreach (var certainAnimal in certainAnimals)
            {
                _output.Write(certainAnimal.Voice());
            }
            
        }
    }
}
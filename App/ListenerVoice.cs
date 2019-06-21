using System;
using System.Collections.Generic;
using System.Linq;
using Classes.Interfaces;

namespace App
{
    public class ListenerVoice : IHearVoice
    {
        private IOutput iOutput;

        public ListenerVoice(IOutput iOutput)
        {
            this.iOutput = iOutput;
        }
        
        public void Voice<T>(IEnumerable<IPet> animals) where T : IPet
        {
            var certainAnimals = animals.OfType<T>();
            foreach (var certainAnimal in certainAnimals)
            {
                iOutput.Write(certainAnimal.Voice());
            }
            
        }
    }
}
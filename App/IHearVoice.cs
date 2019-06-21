using System.Collections.Generic;
using System.Linq;
using Classes.Interfaces;

namespace App
{
    public interface IHearVoice
    {
        void Voice<T>(IEnumerable<IPet> animals) where T : IPet;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractFactory
{
    public  abstract class MidiaSocialAbstrata
    {
        public abstract void Post(string titulo, string corpo);

        public abstract void like();
    }
}

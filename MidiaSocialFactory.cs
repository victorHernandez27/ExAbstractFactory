using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractFactory
{
    public class MidiaSocialFactory : AbstractFactory
    {
        public override MidiaSocialAbstrata CreateMidiaSocial()
        {
            return new MidiaSocial2();
        }
    }
}

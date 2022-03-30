using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractFactory
{
    public class MidiaSocial2 : MidiaSocialAbstrata
    {
        public override void like()
        {
            Console.WriteLine("Post Curtido no Twitter");
        }

        public override void Post(string titulo, string corpo)
        {
            Console.Error.WriteLine(titulo);
            Console.Error.WriteLine(corpo + "Twitter");
        }
    }
}

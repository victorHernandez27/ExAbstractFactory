using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExAbstractFactory
{
    internal class MidiaSocial : MidiaSocialAbstrata
    {
        public override void like()
        {
            Console.WriteLine("Seu Post recebeu um Like No FaceBook");
        }

        public override void Post(string titulo, string corpo)
        {
            Console.Error.WriteLine(titulo);
            Console.Error.WriteLine(corpo +"FaceBook");

        }
    }
}

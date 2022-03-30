using System;

namespace ExAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory factory = new MidiaSocialFactory();
            var midiaSocial = factory.CreateMidiaSocial();

            midiaSocial.Post(titulo:"Titulo do Post", corpo:"Publicacao 1 no ");
            midiaSocial.like();
        }
    }
}

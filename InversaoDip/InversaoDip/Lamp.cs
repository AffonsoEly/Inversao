using System;

namespace InversaoDip
{
    public class Lamp : IDevice
    {
        private State State;

        public Lamp(State state)
        {
            State = state;
        }

        public void Operate()
        {
            State = State == State.On ? State.Off : State.On;
            Console.WriteLine("Luz " + (State == State.On ? "Ligada" : "Desligada"));
        }
    }
}
enum State { On, Off }

class Lamp
{
    State State;

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

class Switch
{
    private Lamp lamp;

    public Switch(Lamp device)
    {
        this.lamp = device;
    }

    public void Press()
    {
        lamp.Operate();
    }
}

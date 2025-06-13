using InversaoDip;

class Program
{
    static void Main(string[] args)
    {
        var lamp = new Lamp(State.Off);
        var sw = new Switch(lamp);

        sw.Press(); // Liga a luz
        sw.Press(); // Desliga a luz
    }
}

namespace InversaoDip
{
    public class Switch
    {
        private IDevice device;

        public Switch(IDevice device)
        {
            this.device = device;
        }

        public void Press()
        {
            device.Operate();
        }
    }
}

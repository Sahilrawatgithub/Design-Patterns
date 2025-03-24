namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            RemoteControl rc = new RemoteControl(tv);

            rc.TogglePower();
            rc.VolumeUp();

            IDevice radio=new Radio();  
            RemoteControl vc= new RemoteControl(radio);

            vc.TogglePower();
            vc.VolumeUp();
        }
    }
}

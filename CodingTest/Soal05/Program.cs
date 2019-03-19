using GHIElectronics.TinyCLR.BrainPad;

namespace Soal05
{
    class Program
    {
        public void BrainPadSetup()
        {
            //Put your setup code here. It runs once when the BrainPad starts up.

            BrainPad.Display.DrawText(0, 0, "Hello!");
        }

        public void BrainPadLoop()
        {
            //Put your program code here. It runs repeatedly after the BrainPad starts up.

            BrainPad.LightBulb.TurnWhite();
            BrainPad.Wait.Seconds(1);
            BrainPad.LightBulb.TurnOff();
            BrainPad.Wait.Seconds(1);
        }
    }
}

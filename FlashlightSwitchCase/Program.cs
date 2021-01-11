using System;

namespace FlashlightGoFState
{
    class Program
    {
        static void Main(string[] args)
        {
            IFlashlight f = new Flashlight();
            f.Power();
            f.Mode();
            f.Mode();
            f.Power();
        }
    }
}

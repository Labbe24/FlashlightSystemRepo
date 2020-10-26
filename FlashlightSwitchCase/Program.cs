using System;

namespace FlashlightGoFState
{
    class Program
    {
        static void Main(string[] args)
        {
            Flashlight f = new Flashlight();
            f.Power();
            f.SetHighBeam();
            f.Power();
            f.Power();
            f.Power();
        }
    }
}

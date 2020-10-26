using System;
using FlashlightGoFState.States;

namespace FlashlightGoFState
{
    public class Flashlight
    {
        private static FlashlightState _state;

        public Flashlight()
        {
            _state = new FlashlightOffState();
        }
        public void Power()
        {
            _state.HandlePower(this);
        }

        public void Mode()
        {
            _state.HandleMode(this);
        }

        public void LightOn()
        {
            Console.WriteLine("Light ON");
        }

        public void LightOff()
        {
            Console.WriteLine("Light OFF");
        }

        public void SetLowBeam()
        {
            Console.WriteLine("LOW beam");
        }

        public void SetHighBeam()
        {
            Console.WriteLine("HIGH beam");
        }

        public void SetState(FlashlightState s)
        {
            _state = s;
        }
    }
}
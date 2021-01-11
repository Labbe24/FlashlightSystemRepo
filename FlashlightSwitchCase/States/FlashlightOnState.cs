using System;

namespace FlashlightGoFState.States
{
    public class FlashlightOnState : FlashlightState
    {
        public override void HandlePower(Flashlight f)
        {
            f.SetState(offState);
        }

        public override void HandleMode(Flashlight f)
        {
            throw new NotImplementedException();
        }
        
        public override void OnEnter(Flashlight f)
        {
            f.LightOn();
            f.SetState(loState);
        }
    }
}
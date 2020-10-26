using System;

namespace FlashlightGoFState.States
{
    public class FlashlightOnState : FlashlightState
    {
        public override void HandlePower(Flashlight f)
        {
            f.LightOff();
            f.SetState(offState);
        }

        public override void HandleMode(Flashlight f)
        {
            throw new NotImplementedException();
        }
        
        public void OnEnter(Flashlight f)
        {
            f.SetState(loState);
        }
    }
}
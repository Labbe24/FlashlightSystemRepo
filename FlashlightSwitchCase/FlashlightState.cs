using FlashlightGoFState.States;

namespace FlashlightGoFState
{
    public abstract class FlashlightState
    {
        protected static FlashlightOnState onState = new FlashlightOnState();
        protected static FlashlightOffState offState = new FlashlightOffState();
        protected static OnHighState hiState = new OnHighState();
        protected static OnLowState loState = new OnLowState();
        public abstract void HandlePower(Flashlight f);
        public abstract void HandleMode(Flashlight f);
        public abstract void OnEnter(Flashlight f);
    }
}
namespace FlashlightGoFState.States
{
    public class FlashlightOffState : FlashlightState
    {
        public override void HandlePower(Flashlight f)
        {
            f.LightOn();
            f.SetState(onState);
        }

        public override void HandleMode(Flashlight f)
        {
            throw new System.NotImplementedException();
        }
    }
}
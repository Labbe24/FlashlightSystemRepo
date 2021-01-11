namespace FlashlightGoFState.States
{
    public class FlashlightOffState : FlashlightState
    {
        public override void HandlePower(Flashlight f)
        {
            f.SetState(onState);
        }

        public override void HandleMode(Flashlight f)
        {
            throw new System.NotImplementedException();
        }

        public override void OnEnter(Flashlight f)
        {
            f.LightOff();
        }
    }
}
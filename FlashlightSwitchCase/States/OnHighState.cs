namespace FlashlightGoFState.States
{
    public class OnHighState : FlashlightOnState
    {
        public override void HandleMode(Flashlight f)
        {
            f.SetHighBeam();
            f.SetState(loState);
        }
    }
}
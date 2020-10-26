namespace FlashlightGoFState.States
{
    public class OnLowState : FlashlightOnState
    {
        public override void HandleMode(Flashlight f)
        {
            f.SetLowBeam();
            f.SetState(hiState);
        }
    }
}
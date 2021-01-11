namespace FlashlightGoFState.States
{
    public class OnLowState : FlashlightOnState
    {
        public override void HandleMode(Flashlight f)
        {
            f.SetState(hiState);
        }

        public override void OnEnter(Flashlight f)
        {
            f.SetLowBeam();
        }
    }
}
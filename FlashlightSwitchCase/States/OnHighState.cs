namespace FlashlightGoFState.States
{
    public class OnHighState : FlashlightOnState
    {
        public override void HandleMode(Flashlight f)
        {
            f.SetState(loState);
        }

        public override void OnEnter(Flashlight f)
        {
            f.SetHighBeam();
        }
    }
}
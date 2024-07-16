using UnityEngine;

public class SamuraiClimbState : SamuraiBaseState
{
    public SamuraiClimbState(SamuraiStateManager stateManager) : base(stateManager) { }

    protected override Samurai Samurai { get; set; }
    protected override Animator SamuraiAnimator { get; set; }
    protected override CharacterInput SamuraiInput { get; set; }
    public override void EnterState()
    {
        
    }

    public override void UpdateState()
    {
       
    }

    public override void ExitState()
    {
        
    }

    public override void CheckState()
    {
        
    }
}

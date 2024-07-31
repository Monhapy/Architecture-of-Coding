public class SamuraiWalkState : SamuraiBaseState
{
    public override void EnterState(SamuraiStateManager stateManager)
    {
        
    }

    public override void UpdateState(SamuraiStateManager stateManager)
    {
        stateManager.samuraiMovement.Walk(SamuraiInput.WalkInput);
        stateManager.samuraiAnimation.WalkAnim(SamuraiInput.WalkInput);
        CheckState(stateManager);
    }

    public override void ExitState(SamuraiStateManager stateManager)
    {
        
    }

    public override void CheckState(SamuraiStateManager stateManager)
    {
        if (SamuraiInput.WalkInput==0)
        {
            stateManager.ChangeState(new SamuraiIdleState());
        }

        if (SamuraiInput.AttackInput)
        {
            stateManager.ChangeState(new SamuraiAttackState());
        }
    }
}
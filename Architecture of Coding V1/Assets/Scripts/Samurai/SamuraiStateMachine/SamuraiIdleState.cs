public class SamuraiIdleState : SamuraiBaseState
{
    public override void EnterState(SamuraiStateManager stateManager)
    {
        
    }

    public override void UpdateState(SamuraiStateManager stateManager)
    {
        CheckState(stateManager);
    }

    public override void ExitState(SamuraiStateManager stateManager)
    {
        
    }

    public override void CheckState(SamuraiStateManager stateManager)
    {
        if (SamuraiInput.WalkInput!=0)
        {
            stateManager.ChangeState(new SamuraiWalkState());
        }
        
        if (SamuraiInput.AttackInput)
        {
            stateManager.ChangeState(new SamuraiAttackState());
        }
    }
}
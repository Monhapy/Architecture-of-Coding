public class SamuraiAttackState : SamuraiBaseState
{
    
    public override void EnterState(SamuraiStateManager stateManager)
    {
        
    }

    public override void UpdateState(SamuraiStateManager stateManager)
    {
        if (stateManager.samuraiAnimation.attackCount == 0)
        {
            stateManager.samuraiAnimation.FirstAttackAnim();
        }
        else if (stateManager.samuraiAnimation.attackCount == 1)
        {
            stateManager.samuraiAnimation.SecondAttackAnim();
        }
        CheckState(stateManager);
    }

    public override void ExitState(SamuraiStateManager stateManager)
    {
        
    }

    public override void CheckState(SamuraiStateManager stateManager)
    {
        if (!SamuraiInput.AttackInput)
        {
            if (SamuraiInput.WalkInput==0)
            {
                stateManager.ChangeState(new SamuraiIdleState());
            }
        }
    }
}
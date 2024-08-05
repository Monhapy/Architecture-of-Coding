public class PlayerIdleState : PlayerBaseState
{
    
    public override void EnterState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        
    }

    public override void UpdateState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        ChangeState(stateManager);
    }

    public override void ExitState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        
    }

    public override void ChangeState(PlayerStateManager stateManager)
    {
        if (PlayerInput.HorizontalInput!=0 || PlayerInput.VerticalInput!=0)
        {
            stateManager.ChangeState(new PlayerWalkState());
        }
    }


    
}
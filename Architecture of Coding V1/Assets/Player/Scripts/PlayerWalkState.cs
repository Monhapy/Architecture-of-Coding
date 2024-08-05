public class PlayerWalkState : PlayerBaseState
{
    
    public override void EnterState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        
    }

    public override void UpdateState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        behaviours.PlayerMovement.Walk();
        ChangeState(stateManager);
    }

    public override void ExitState(PlayerStateManager stateManager,PlayerBehaviours behaviours)
    {
        
    }

    public override void ChangeState(PlayerStateManager stateManager)
    {
        if (PlayerInput.HorizontalInput == 0 && PlayerInput.VerticalInput == 0)
        {
            stateManager.ChangeState(new PlayerIdleState());
        }
    }


    
}
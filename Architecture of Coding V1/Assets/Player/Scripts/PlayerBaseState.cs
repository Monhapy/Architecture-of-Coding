using System;

public abstract class PlayerBaseState
{
    public abstract void EnterState(PlayerStateManager stateManager,PlayerBehaviours behaviours);
    public abstract void UpdateState(PlayerStateManager stateManager,PlayerBehaviours behaviours);
    public abstract void ExitState(PlayerStateManager stateManager,PlayerBehaviours behaviours);
    public abstract void ChangeState(PlayerStateManager stateManager);
}
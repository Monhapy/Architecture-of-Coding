public abstract class SamuraiBaseState
{
    public abstract void EnterState(SamuraiStateManager stateManager);
    public abstract void UpdateState(SamuraiStateManager stateManager);
    public abstract void ExitState(SamuraiStateManager stateManager);
    public abstract void CheckState(SamuraiStateManager stateManager);
}
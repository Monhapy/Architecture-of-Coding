public abstract class MageBaseState 
{
    public abstract void EnterState(MageStateManager stateManager);
    public abstract void UpdateState(MageStateManager stateManager);
    public abstract void ExitState(MageStateManager stateManager);
    public abstract void CheckState(MageStateManager stateManager);
}
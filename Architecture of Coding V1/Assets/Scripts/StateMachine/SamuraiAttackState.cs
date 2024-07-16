using UnityEngine;

public class SamuraiAttackState : SamuraiBaseState
{
    protected override Samurai Samurai { get; set; }
    protected override Animator SamuraiAnimator { get; set; }
    protected override CharacterInput SamuraiInput { get; set; }

    public SamuraiAttackState(SamuraiStateManager stateManager) : base(stateManager) { }

    public override void EnterState()
    {
        SamuraiAnimator = _stateManager.samuraiAnimator;
        SamuraiInput = _stateManager.CurrentInput;
        Samurai = new Samurai(SamuraiAnimator, SamuraiInput);
    }

    public override void UpdateState()
    {
        CheckState();
        Samurai.Attack();
        Debug.Log("Attack Updating");
    }

    public override void ExitState()
    {
       
    }

    public override void CheckState()
    {
        if (!_stateManager.CurrentInput.MouseInput)
        {
            if (_stateManager.CurrentInput.HorizontalInput != 0)
            {
                _stateManager.ChangeState(new SamuraiWalkState(_stateManager));
            }
            
            if (_stateManager.CurrentInput.HorizontalInput == 0)
            {
                _stateManager.ChangeState(new SamuraiIdleState(_stateManager));
            }
        }
    }
}

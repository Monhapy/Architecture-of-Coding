using UnityEngine;

public class SamuraiIdleState : SamuraiBaseState
{
    public SamuraiIdleState(SamuraiStateManager stateManager) : base(stateManager) { }
    protected override Samurai Samurai { get; set; }
    protected override Animator SamuraiAnimator { get; set; }
    protected override CharacterInput SamuraiInput { get; set; }
    
    private Transform _transform;
    
    private float _moveSpeed;
    
    

    public override void EnterState()
    {
        Samurai = new Samurai(SamuraiAnimator, SamuraiInput);
        SamuraiAnimator = _stateManager.samuraiAnimator;
        SamuraiInput = _stateManager.CurrentInput;
        
    }

    public override void UpdateState()
    {
        CheckState();
        Debug.Log("Idle Updating");
    }

    public override void ExitState()
    {
        
    }

    public override void CheckState()
    {
        if (_stateManager.CurrentInput.HorizontalInput != 0)
        {
            _stateManager.ChangeState(new SamuraiWalkState(_stateManager));
        }
        if (_stateManager.CurrentInput.MouseInput)
        {
            _stateManager.ChangeState(new SamuraiAttackState(_stateManager));
        }
    }


   
}

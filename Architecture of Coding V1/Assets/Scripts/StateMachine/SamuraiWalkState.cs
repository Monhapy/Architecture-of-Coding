using UnityEngine;

public class SamuraiWalkState : SamuraiBaseState
{
    public SamuraiWalkState(SamuraiStateManager stateManager) : base(stateManager) { }
    protected override Samurai Samurai { get; set; }
    protected override Animator SamuraiAnimator { get; set; }
    protected override CharacterInput SamuraiInput { get; set; }

    private Transform _transform;
    
    private float _moveSpeed;
   
    public override void EnterState()
    {
        SamuraiAnimator = _stateManager.samuraiAnimator;
        SamuraiInput= _stateManager.CurrentInput;
        Samurai = new Samurai(SamuraiAnimator, SamuraiInput);
        
        _moveSpeed = _stateManager.samuraiMoveSpeed;
        _transform = _stateManager.samuraiTransform;
    }

    public override void UpdateState()
    {
        CheckState();
        Samurai.Walk(_moveSpeed,_transform);
        Debug.Log("Walk Updating");
    }

    public override void ExitState()
    {
        
    }
    public override void CheckState()
    {
        if (_stateManager.CurrentInput.HorizontalInput == 0)
        {
            _stateManager.ChangeState(new SamuraiIdleState(_stateManager));
        }
        if (_stateManager.CurrentInput.MouseInput)
        {
            _stateManager.ChangeState(new SamuraiAttackState(_stateManager));
        }
        
    }
    
}

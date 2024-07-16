using System;
using UnityEngine;

public class SamuraiStateManager : MonoBehaviour
{
    private SamuraiBaseState _currentState;
    public CharacterInput CurrentInput;

    public float samuraiMoveSpeed;
    public Transform samuraiTransform;
    public Animator samuraiAnimator;
    
    private void Start()
    {
        CurrentInput = new CharacterInput();
        _currentState = new SamuraiIdleState(this);
        _currentState.EnterState();
    }

    private void Update()
    {
        CurrentInput.UpdateInputs();
        _currentState.UpdateState();
    }

    public void ChangeState(SamuraiBaseState newState)
    {
        _currentState.ExitState();
        _currentState = newState;
        _currentState.EnterState();
    }

    
}

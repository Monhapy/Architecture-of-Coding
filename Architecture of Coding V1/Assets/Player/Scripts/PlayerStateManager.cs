using System;
using UnityEngine;

public class PlayerStateManager : MonoBehaviour
{
    private PlayerBaseState _currentState;
    [HideInInspector] public PlayerBehaviours behaviours;
    private void Awake()
    {
        _currentState = new PlayerIdleState();
        behaviours = gameObject.GetComponent<PlayerBehaviours>();
    }

    private void Start()
    {
        _currentState.EnterState(this,behaviours);
    }
    private void Update()
    {
        _currentState.UpdateState(this,behaviours);
    }

    public void ChangeState(PlayerBaseState newState)
    {
        _currentState.ExitState(this,behaviours);
        _currentState = newState;
        _currentState.EnterState(this,behaviours);
    }
}
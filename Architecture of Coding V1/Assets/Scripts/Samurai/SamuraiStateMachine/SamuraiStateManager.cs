using System;
using UnityEngine;

public class SamuraiStateManager : MonoBehaviour
{
    [HideInInspector] public SamuraiMovement samuraiMovement;
    [HideInInspector] public SamuraiCollisionDetection samuraiCollision;
    [HideInInspector] public SamuraiAnimation samuraiAnimation;
    
    private SamuraiBaseState _currentState;
    
    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _currentState = new SamuraiIdleState();
        samuraiMovement = GetComponent<SamuraiMovement>();
        samuraiCollision = GetComponent<SamuraiCollisionDetection>();
        samuraiAnimation = GetComponent<SamuraiAnimation>();
    }

    private void Start()
    {
        _currentState.EnterState(this);
    }

    private void Update()
    {
        _currentState.UpdateState(this);
    }

    public void ChangeState(SamuraiBaseState newState)
    {
       _currentState.ExitState(this);
       _currentState = newState;
       _currentState.EnterState(this);
    }
}
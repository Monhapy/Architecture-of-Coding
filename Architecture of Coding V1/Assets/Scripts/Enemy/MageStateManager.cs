using UnityEngine;

public class MageStateManager : MonoBehaviour
{
    [HideInInspector] public MageMovement mageMovement;
    [HideInInspector] public MageAttack mageAttack;
    [HideInInspector] public MageAnimation mageAnimation;
    
    private MageBaseState _currentState;
    
    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _currentState = new MageIdleState();
        mageMovement = GetComponent<MageMovement>();
        mageAttack = GetComponent<MageAttack>();
        mageAnimation = GetComponent<MageAnimation>();

    }

    private void Start()
    {
        _currentState.EnterState(this);
    }

    private void Update()
    {
        _currentState.UpdateState(this);
    }

    public void ChangeState(MageBaseState newState)
    {
        _currentState.ExitState(this);
        _currentState = newState;
        _currentState.EnterState(this);
    }
}

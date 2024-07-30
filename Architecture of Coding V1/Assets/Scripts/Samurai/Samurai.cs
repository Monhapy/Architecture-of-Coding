using System;
using UnityEngine;

public class Samurai : MonoBehaviour
{
    private SamuraiInput _samuraiInput;
    private SamuraiMovement _samuraiMovement;
    private SamuraiCollisionDetection _samuraiCollision;
    
    
    private void Awake()
    {
        Initialize();
    }

    private void Initialize()
    {
        _samuraiInput = GetComponent<SamuraiInput>();
        _samuraiMovement = GetComponent<SamuraiMovement>();
        _samuraiCollision = GetComponent<SamuraiCollisionDetection>();
    }

    private void Update()
    {
        _samuraiInput.HandleInputs();
    }

    private void FixedUpdate()
    {
        _samuraiMovement.Walk(_samuraiInput.walkInput);
        //_samuraiMovement.Jump(_samuraiInput.jumpInput,_samuraiCollision.isGround);
    }
}
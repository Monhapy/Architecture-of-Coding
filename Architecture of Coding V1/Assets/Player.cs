using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float pWalkSpeed;
    [SerializeField] private Transform pTransform;

    private float _horizontalInput;
    private float _verticalInput;
    private Vector3 _moveVector;


    private void Update()
    {
        GetWalkInputs();
        Walk(_horizontalInput,_verticalInput);
    }

    private void Walk(float horizontalInput,float verticalInput)
    {
        _moveVector = new Vector3(horizontalInput, 0f, verticalInput);
        pTransform.position += _moveVector * (pWalkSpeed * Time.deltaTime);
    }

    private void GetWalkInputs()
    {
        _horizontalInput= Input.GetAxisRaw("Horizontal");
        _verticalInput = Input.GetAxisRaw("Vertical");
    }
    
    
    
    
}

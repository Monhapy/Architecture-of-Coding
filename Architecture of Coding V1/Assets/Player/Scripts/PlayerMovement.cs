using System;
using UnityEngine;

public class PlayerMovement
{
    public PlayerMovement(float moveSpeed, Transform playerTransform,Animator playerAnimator)
    {
        this._moveSpeed = moveSpeed;
        this._playerTransform = playerTransform;
        this._playerAnimator = playerAnimator;
    }

    private readonly float _moveSpeed;
    private readonly Transform _playerTransform;
    private readonly Animator _playerAnimator;
    
    private Vector3 _walkVector;
    private float _horizontalInput;
    private float _verticalInput;
    
    public void Walk()
    {
        _horizontalInput = PlayerInput.HorizontalInput;
        _verticalInput = PlayerInput.VerticalInput;
        
        var position = _playerTransform.position;
        _walkVector = new Vector3(_horizontalInput, position.y, _verticalInput);
        position += _walkVector * (_moveSpeed * Time.deltaTime);
        
        _playerTransform.position = position;
        WalkAnim();
        
    }

    private void WalkAnim()
    {
        var isWalking = Animator.StringToHash("isWalking");
        if (_verticalInput != 0)
        {
            _playerAnimator.SetBool(isWalking,true);
        }
        else
        {
            _playerAnimator.SetBool(isWalking,false);
        }
    }
    
}



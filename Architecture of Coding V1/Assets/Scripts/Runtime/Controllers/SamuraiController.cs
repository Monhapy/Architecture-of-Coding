using System;
using UnityEngine;

public class SamuraiController : MonoBehaviour
{
    private Samurai _samurai;
    private CharacterInput _characterInput;
    
    [SerializeField] private float moveSpeed;
    private float _horizontalInput;
    [SerializeField] private Animator samuraiAnimator;

    private void Awake()
    {
        _characterInput = new CharacterInput();
        //_samurai = new Samurai(moveSpeed,this.gameObject,samuraiAnimator,_characterInput);
    }

    

    
}
using System;
using UnityEngine;

public class SamuraiController : MonoBehaviour
{
    private Samurai _samurai;
    private CharacterInput _characterInput;
    
    [SerializeField] private float moveSpeed;
    private float _horizontalInput;

    private void Awake()
    {
        _samurai = new Samurai(moveSpeed,this.gameObject);
        _characterInput = new CharacterInput();
    }

    private void Update()
    {
        SamuraiWalk();
    }

    private void SamuraiWalk()
    {
        _horizontalInput = _characterInput.WalkInput();
        _samurai.Walk(_horizontalInput);
    }
}
using System;
using UnityEngine;

public class PlayerBehaviours : MonoBehaviour
{
    [Header("PlayerMovement")] 
    [SerializeField] private float playerMoveSpeed;
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Animator playerAnimator;
    
    //Behaviours
    [HideInInspector] public PlayerMovement PlayerMovement;
    
    private void Awake()
    {
        InitializeBehaviours();
        
    }
    
    private void InitializeBehaviours()
    {
        PlayerMovement = new PlayerMovement(playerMoveSpeed, playerTransform, playerAnimator);
    }

    
}
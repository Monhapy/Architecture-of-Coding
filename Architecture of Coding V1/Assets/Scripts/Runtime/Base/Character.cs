using UnityEngine;

public abstract class Character
{
    public abstract Animator CharacterAnim { get; set; }
    public abstract CharacterInput CharacterInput { get; set; }
    public abstract void Walk(float moveSpeed,Transform samuraiTransform);
    public abstract void Attack();

}
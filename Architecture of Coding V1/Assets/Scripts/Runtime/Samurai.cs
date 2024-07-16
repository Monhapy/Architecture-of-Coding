using System;
using UnityEngine;

public class Samurai: Character
{
    public sealed override Animator CharacterAnim { get; set; }
    public sealed override CharacterInput CharacterInput { get; set; }
    public Samurai(Animator samuraiAnim,CharacterInput samuraiInput)
    {
        CharacterAnim = samuraiAnim;
        CharacterInput = samuraiInput;
    }

    public override void Walk(float moveSpeed,Transform samuraiTransform)
    {
        var horizontalInput = CharacterInput.HorizontalInput;
        Vector3 flipVector = samuraiTransform.localScale;
        
        if (horizontalInput != 0) 
        {
            var position = samuraiTransform.position;
            position += new Vector3(horizontalInput,position.y,position.z) * (moveSpeed * Time.deltaTime);
            samuraiTransform.transform.position = position;
            
            flipVector.x = horizontalInput;
            samuraiTransform.localScale = flipVector;
        }
        
        CharacterAnim.SetFloat("Speed",MathF.Abs(horizontalInput));
        
    }

    public override void Attack()
    {
        CharacterAnim.SetTrigger("Attack");
        
    }

    public void Climb()
    {
        
    }

    
    
}
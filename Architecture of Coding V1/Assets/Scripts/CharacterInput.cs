using UnityEngine;

public class CharacterInput
{
    public float HorizontalInput { get; set; }
    
    public float WalkInput()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        return HorizontalInput;
    }   
}
    

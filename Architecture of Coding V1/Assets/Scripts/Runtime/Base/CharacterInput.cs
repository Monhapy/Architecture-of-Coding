using UnityEngine;

public class CharacterInput
{
    public float HorizontalInput { get; private set; }
    public bool MouseInput { get; private set; }

    public void UpdateInputs()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        MouseInput = Input.GetMouseButtonDown(0);
    }

    
}
    

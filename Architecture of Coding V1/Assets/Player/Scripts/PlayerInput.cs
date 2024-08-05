using UnityEngine;

public static class PlayerInput
{
    public static float HorizontalInput;
    public static float VerticalInput;

    public static void HandleInputs()
    {
        WalkInputs();
    }
    private static void WalkInputs()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }
}
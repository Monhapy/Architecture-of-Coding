using System;
using UnityEngine;

public static class SamuraiInput 
{
    public static float WalkInput;
    public static bool AttackInput;

    public static void HandleInputs()
    {
        WalkInput = Input.GetAxisRaw("Horizontal");
        AttackInput = Input.GetMouseButtonDown(0);
    }
}
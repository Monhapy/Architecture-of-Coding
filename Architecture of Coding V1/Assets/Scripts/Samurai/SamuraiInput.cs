using UnityEngine;

public class SamuraiInput : MonoBehaviour
{
    public float walkInput;
    public bool jumpInput;

    public void HandleInputs()
    {
        walkInput = Input.GetAxisRaw("Horizontal");
        jumpInput = Input.GetMouseButtonDown(0);
    }
}
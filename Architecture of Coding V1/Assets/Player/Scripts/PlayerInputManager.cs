using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{
    private void Update()
    {
        PlayerInput.HandleInputs();
    }
}
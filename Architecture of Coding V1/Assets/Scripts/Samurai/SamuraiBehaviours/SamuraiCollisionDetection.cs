using System;
using UnityEngine;

public class SamuraiCollisionDetection : MonoBehaviour
{
    public bool isGround;
    private IInteractable _interactable;
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<IInteractable>()!= null)
        {
            _interactable = other.GetComponent<IInteractable>();
            _interactable.Interact();
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<IInteractable>()!= null)
        {
            _interactable = other.GetComponent<IInteractable>();
            _interactable.Disengage();
        }
    }

    
}
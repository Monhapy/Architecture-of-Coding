using UnityEngine;
using UnityEngine.UI;


public interface IInteractable
{
    public Button RefButton { get; set; }
    public void Interact();
    public void Disengage();
}
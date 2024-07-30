using UnityEngine;
using UnityEngine.UI;

public class Ladder : MonoBehaviour,IInteractable
{
    public Button RefButton { get; set; }
    
    [SerializeField] private Button currentButton;

    private void Awake()
    {
        RefButton = currentButton;
    }

    public void Interact()
    {
        
        RefButton.gameObject.SetActive(true);
    }

    public void Disengage()
    {
        
        RefButton.gameObject.SetActive(false);
    }
}
using UnityEngine;

public class DefaultButton : InteractButtons
{
    [SerializeField] private bool isActing;
    
    public override void PerformAction()
    {
        ActionStart();
    }

    private void ActionStart()
    {
        Debug.Log("AnimationPlaying");
        isActing = true;
        gameObject.SetActive(false);
    }

    private void ActionEnd()
    {
        Debug.Log("AnimationEnd");
        isActing = false;
        gameObject.SetActive(true);
    }
    
}
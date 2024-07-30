using UnityEngine;

public class ChangePlaceButton : InteractButtons
{
    public override void PerformAction()
    {
        ChangePlace();
    }

    private void ChangePlace()
    {
        Debug.Log("PlaceChanged");
        
    }
}
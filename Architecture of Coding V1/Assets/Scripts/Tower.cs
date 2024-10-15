using UnityEngine;

public class Tower : MonoBehaviour,IHookable
{
    public void OnHooked(Vector3 hookPoint)
    {
        // Hook işlemi sırasında yapılacak işlemler buraya gelir
        Debug.Log("Tower hooked at: " + hookPoint);
    }
}
using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private int sceneItemCount;
    public static int NecessaryItemCount;
    [SerializeField] private Button changeButton;
    
    
    public static LevelManager Instance;
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this; 
        }
        else
        {
            Destroy(gameObject); 
        }
    }

    private void Update()
    {
        if (sceneItemCount == NecessaryItemCount)
        {
            changeButton.gameObject.SetActive(true);
            Debug.Log(NecessaryItemCount);
        }
    }
}

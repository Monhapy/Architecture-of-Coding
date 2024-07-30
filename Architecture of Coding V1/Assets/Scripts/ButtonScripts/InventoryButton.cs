using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class InventoryButton : InteractButtons
{
    [SerializeField] private InventoryItems currentItem;
    [SerializeField] private Image inventoryItemUI;
    [SerializeField] private GameObject sceneItem;
    
    public override void PerformAction()
    {
        AddItem();
        gameObject.SetActive(false);
    }

    private void AddItem()
    {
        Debug.Log("ItemAdded");
        inventoryItemUI.sprite = currentItem.itemSprite;
        Destroy(sceneItem);
        
        
        var color = inventoryItemUI.color;
        color.a = 100;
        inventoryItemUI.color = color;

        LevelManager.NecessaryItemCount += 1;

    }
}
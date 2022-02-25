using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class InventorySlot : MonoBehaviour
{
    [Header("")]
    [SerializeField] private TextMeshProUGUI itemNumberText;
    [SerializeField] private Image itemImage;
    [Header("Variables from the item")]
    //public Sprite itemSprite;
    //public int numberHeld;
    //public string itemDescription;
    public InventoryItem thisItem;
    public InventoryManager thisManager;

    public void Setup(InventoryItem newItem, InventoryManager newManager)
    {
        thisItem = newItem;
        thisManager = newManager;
        if (thisItem)
        {
            
            Debug.Log(thisItem.mySprite);
            if (newItem.mySprite) {
                itemImage.sprite = thisItem.mySprite;
                itemNumberText.text = "" + thisItem.numberHeld;
            }
            
        }
    }
    public void ClickedOn()
    {
        if (thisItem)
        {
            thisManager.SetupDescriptionAndButton(thisItem.myDescription, thisItem.isUsable, thisItem);
        }
    }
}

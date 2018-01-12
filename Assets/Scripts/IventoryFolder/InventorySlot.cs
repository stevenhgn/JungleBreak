using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    // Image variable icon
    public Image icon;
    // Button call removeButton
    public Button removeButton;

    ItemScript item;

    // Add item methods that takes in one parameter Item from the item script

    public void AddItem (ItemScript newItem) {
        // local variable item equal newItem
        item = newItem;

        // sets the icon sprite to items icon
        icon.sprite = item.icon;
        // Sets the icon to be enable
        icon.enabled = true;
        // set the removeButton to be interactable
        removeButton.interactable = true;
    }

    public void ClearSlot () {
        item = null;

        icon.sprite = null;
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnRemoveButton () {
        Inventory.instance.Remove(item);
    }

    public void UseItem ()
    {
        if (item != null) {
            item.Use();
        }
    }
}
  
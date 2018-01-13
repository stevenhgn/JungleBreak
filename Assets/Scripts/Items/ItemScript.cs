using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Iventory/Item")]

public class ItemScript : ScriptableObject {
    new public string name = "New Item";
    public string itemID;
    public float damageValue;
    public Sprite icon = null;

    public virtual void Use () {
        // use the item
        //Something might happen

        Debug.Log("Using " + name); 
    }

    public void RemoveFromInventory () {
        Inventory.instance.Remove(this);
    }


}

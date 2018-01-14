using UnityEngine;


[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class ItemScript : ScriptableObject {
    new public string name = "New Item";
    public string itemID;
    public float damageValue;
    public Sprite icon = null;

    public virtual void Use()
    {
        // use the item
        //Something might happen
        Debug.Log("Using " + name);
        // if currentHP pluss or minus the damagevalue is larger than maxHP then --> currentHP with be the MaxHP
        // some kind of bugs making the damageValue to double which cause the currentHp to be wrong. 
        //Temporary fix is to divide the damageValue with 2.
        if (itemID.Substring(0, 1) == "H" && (GameController.instance.currentHp += damageValue/2) > GameController.instance.maxHp)
        {

            //Add the item to iventory
            //GameController.instance.iventory.Add(itemName);
            GameController.instance.currentHp = GameController.instance.maxHp;
            RemoveFromInventory();
        }
        else if(itemID.Substring(0, 1) == "H") {
            GameController.instance.currentHp += damageValue/2;
            RemoveFromInventory();
        }
    }
    public void RemoveFromInventory () {
        Inventory.instance.Remove(this);
    }


}

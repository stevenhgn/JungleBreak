using UnityEngine;

/// <summary>
///  This is an older version of the inventory system which now will be use for 
/// only when something is supposed to happen (like hp raise) when a player clicks on it.
/// </summary>

[CreateAssetMenu(fileName = "New Item", menuName = "Iventory/Item")]

public class ClickAndUseItem : MonoBehaviour
{
    new public string name = "New Item";
    public string itemID;
    public float damageValue;

    void Awake()
    {
    }

    // Use this for initialization
    void Start()
    {
        // If the item was destroyed, it does not need to be recreated

        if (GameController.instance.itemsDestroyStatus.ContainsKey(itemID))
        {
            if (GameController.instance.itemsDestroyStatus[itemID] == false)
            {
                Destroy(gameObject);
            }
        }
    }



    void OnMouseDown()
    {
        Destroy(gameObject);

        //tell the GameController-instance that the item is destroyed
        GameController.instance.itemsDestroyStatus[itemID] = false;

        // heal or deal damage based on itemID - "H" for Health and "T" for Thirstiness
        if (itemID.Substring(0, 1) == "H" && (GameController.instance.currentHp += damageValue) > GameController.instance.maxHp)
        {

            //Add the item to iventory
            //GameController.instance.iventory.Add(itemName);
            GameController.instance.currentHp = GameController.instance.maxHp;

        }
        // Same but for thirstiness
        //int count = 0;
        if (itemID.Substring(0, 1) == "T" && ((GameController.instance.currentThirst += damageValue) > GameController.instance.maxThirst))
        {
            GameController.instance.currentThirst = GameController.instance.maxThirst;
            //Destroy(gameObject);
            //count++;

        }
    }
}
            
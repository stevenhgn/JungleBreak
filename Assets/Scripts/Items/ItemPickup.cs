using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    public ItemScript item;


    void OnMouseDown()
    {
        Debug.Log("Picking up " + item.name);
        // Add to iventory
        bool wasPickedUp = Inventory.instance.Add(item);

        if (wasPickedUp)
            Destroy(gameObject);


    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    
    public static HUDScript instance;

    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;

    InventoryUI inventoryUI2;


    // Use this for initialization
    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += inventoryUI2.UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    void Awake()
    {
        // If we don't currently have a game controll....
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);
        DontDestroyOnLoad(this); // this object needs to be kept throughout the wholegame
    }

    /*
    void Update()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += inventoryUI2.UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();

    }*/
}

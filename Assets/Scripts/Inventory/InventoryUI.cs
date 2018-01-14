using UnityEngine;

public class InventoryUI : MonoBehaviour
{


    // Not working entirely because of the fact that it only hold the information of the first time,.
    //public static InventoryUI instance;

    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;

    InventorySlot[] slots;

    /*
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
    }*/

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);

        }
    }

    public void UpdateUI()
    {

        for (int i = 0; i < slots.Length; i++)
        {
            // if i is less than the amount of items in inventory
            if (i < inventory.items.Count)
            {
                // add this item on index i to the slots on index i.
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}


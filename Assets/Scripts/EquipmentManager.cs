using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    #region Singleton
    public static EquipmentManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    Equipment[] currentEquipment;

    // Invoke later
    public delegate void OnEquipmentChanged(Equipment newItem, Equipment oldItem);
    public OnEquipmentChanged onEquipmentChanged;


    //
    Inventory inventory;

    private void Start()
    {
        inventory = Inventory.instance;

        int numSlots = System.Enum.GetNames(typeof(EquipmentSlot)).Length;
        currentEquipment = new Equipment[numSlots];
            
    }

    // Method that Equip an item
    public void Equip (Equipment newItem) 
    {
        int slotIndex = (int)newItem.equipSlot;

        Equipment oldItem = null;

        if(currentEquipment[slotIndex] != null) 
        {
            oldItem = currentEquipment[slotIndex];
            inventory.Add(oldItem);
        }

        // invoke items
        if (onEquipmentChanged != null) 
        {
            onEquipmentChanged.Invoke(newItem, oldItem);
        }

        currentEquipment[slotIndex] = newItem;
    }

    // method that unequip an item

    public void Unequip (int slotIndex) {
        // if the current equipment at slot index not equal to null
        if (currentEquipment[slotIndex] != null) 
        {
            // the old equipment will be the current equipment at the slotindex
            Equipment oldItem = currentEquipment[slotIndex];
            // add the old item back to inventory
            inventory.Add(oldItem);

            // make the currentEquipment index equals null
            currentEquipment[slotIndex] = null;

            // invoke items
            if (onEquipmentChanged != null)
            {
                onEquipmentChanged.Invoke(null, oldItem);
            }

        }
    }

    // unEquip all method
    public void UnequipAll() {
        for (int i = 0; i < currentEquipment.Length; i++)
        {
            Unequip(i);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
            UnequipAll();
    }


}

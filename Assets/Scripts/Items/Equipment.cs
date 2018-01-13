﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment",menuName = "Inventory/Equipment")]
public class Equipment : ItemScript {
    
    public EquipmentSlot equipSlot;

    public int armorModifier;
    public int damageModifier;

    public override void Use()
    {
        base.Use();
        //Equip the item
        EquipmentManager.instance.Equip(this);
        //Remove it from the inventory
        RemoveFromInventory();

    }

}

// a enum outside of the class (drop down menu).
public enum EquipmentSlot { Head, Chest, Legs, Weapon, Shiled, Feet}

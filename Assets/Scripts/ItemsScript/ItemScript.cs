﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ItemScript : MonoBehaviour
{
    public string itemName;
    public string itemID;

    void Awake()
    {      
    }

    // Use this for initialization
    void Start()
    {
        // If the item was destroyed, it does not need to be recreated
        if (GameController.instance.itemsDestroyStatus.ContainsKey(itemID)){
            if(GameController.instance.itemsDestroyStatus[itemID] == false){
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        //Add the item to iventory
        GameController.instance.iventory.Add(itemName);

        Destroy(gameObject);

        //tell the GameController-instance that the item is destroyed
        GameController.instance.itemsDestroyStatus[itemID] = false; 

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ItemScript : MonoBehaviour
{
    public string itemName;
    public string itemID;
    public float damageValue;

    void Awake() {      
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
        Destroy(gameObject);
    
        //tell the GameController-instance that the item is destroyed
            GameController.instance.itemsDestroyStatus[itemID] = false; 

        // heal or deal damage based on itemID - "H" for Health and "T" for Thirstiness
        if(itemID.Substring(0, 1) == "H" && (GameController.instance.currentHp += damageValue) > GameController.instance.maxHp){
            
            //Add the item to iventory
            GameController.instance.iventory.Add(itemName);
            GameController.instance.currentHp = GameController.instance.maxHp;

        }
        // Same but for thirstiness
        //int count = 0;
        if (itemID.Substring(0, 1) == "T" && ((GameController.instance.currentThirst += damageValue) > GameController.instance.maxThirst)) {
            GameController.instance.currentThirst = GameController.instance.maxThirst;
            //Destroy(gameObject);
            //count++;

        }
            





    }
}

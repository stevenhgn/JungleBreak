using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ItemScript : MonoBehaviour
{
    public string itemName;
    public bool isDestroyed;
    public string itemID;

    void Awake()
    {      
    }

    // Use this for initialization
    void Start()
    {
        if (GameController.instance.itemsDestroyStatus.ContainsKey(itemID)){
            print("existed");
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
        GameController.instance.iventory.Add(itemName);
        Destroy(gameObject);
        GameController.instance.itemsDestroyStatus[itemID] = false;
    }
}

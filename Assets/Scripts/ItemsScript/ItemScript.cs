using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ItemScript : MonoBehaviour
{
    public string itemName;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameController.instance.iventory.Add(itemName);
        Destroy(gameObject);
    }
}

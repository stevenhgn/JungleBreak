using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static GameController instance;
    //public string[] iventory;
    public List<string> iventory = new List<string>();

    //public PlayerHealth playerHP;


    void Awake()
    {
        // If we don't currently have a game controll....
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
            Destroy(gameObject);
    }
}

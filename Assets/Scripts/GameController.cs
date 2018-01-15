using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public static GameController instance;
    public Dictionary<string, bool> itemsDestroyStatus = new Dictionary<string, bool>();
    public float currentHp { get; set; }
    public float maxHp { get; set; }
    public float currentThirst { get; set; }
    public float maxThirst { get; set; }



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

    void Start()
    {
        maxHp = 100.0f;
        currentHp = maxHp;
        maxThirst = 100.0f;
        currentThirst = maxHp;


    }


    void Die()
    {
        if (currentHp <= 0)
        {
            Debug.Log("You are dead.");
        }
    }
}

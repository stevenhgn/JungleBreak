using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pear : MonoBehaviour
{
    public PlayerHealth playerHP;
    //private PlayerHealth fruitScript;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {
        
        playerHP.Heal(20.0f);
        Destroy(gameObject);
    }
}

/*
PlayerHealth player = GameObject.Find("PlayerHealth").GetComponent<PlayerHealth>();
//PlayerHealth.Heal(20);
player.Heal(20.0f);
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
    public float CurrentHealth { get; set; }
    public float MaxHealth { get; set; }
    public string HealthValue;

    public Slider healthbar;


	// Use this for initialization
	void Start () {
        MaxHealth = 100.0f;
        CurrentHealth = MaxHealth;

        healthbar.value = CalculateHealth();
      
	}
	
	// Update is called once per frame
	void Update () {

        HealthValue = CurrentHealth.ToString("R");

        DealDamage(0.01f);

        /*
        if (Input.GetKeyDown(KeyCode.X))
        {
            DealDamage(6);
        }
        */
	}

    void DealDamage(float damageValue)
    {
        CurrentHealth -= damageValue;
        healthbar.value = CalculateHealth();

        if (CurrentHealth <= 0)
        {
            Die();
        }  
    }

    float CalculateHealth() {
        
        return CurrentHealth / MaxHealth;
    }

    void Die() {
        CurrentHealth = 0;
        Debug.Log("You are dead.");
    }
}

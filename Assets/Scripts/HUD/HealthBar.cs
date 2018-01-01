using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    public Text health;
    private Slider healthbar;

	// Use this for initialization
	void Start () {
        healthbar = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        string healthValue = "";
        healthValue += GameController.instance.currentHp.ToString("0");

        health.text = healthValue + "%";
        // Deal damage to player overtime
        DealDamage(0.01f);
	}

    public void DealDamage(float damageValue)
    {
        GameController.instance.currentHp -= damageValue;
        healthbar.value = CalculateHealth();
    }

    float CalculateHealth()
    {
        return GameController.instance.currentHp / GameController.instance.maxHp;
    }

}

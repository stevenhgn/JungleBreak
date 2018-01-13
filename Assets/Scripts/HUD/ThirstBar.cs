using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstBar : MonoBehaviour
{
    public Text thirst;
    private Slider thirstbar;

    // Use this for initialization
    void Start()
    {
        thirstbar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        string thirstValue = "";
        thirstValue += GameController.instance.currentThirst.ToString("0");

        thirst.text = thirstValue + "%";
        // Deal damage to player overtime
        DealDamage(0.01f);
    }

    public void DealDamage(float damageValue)
    {
        GameController.instance.currentThirst -= damageValue;
        thirstbar.value = CalculateHealth();
    }

    float CalculateHealth()
    {
        return GameController.instance.currentThirst / GameController.instance.maxThirst;
    }

}

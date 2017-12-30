using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDayScript : MonoBehaviour {

    public PlayerHealth playerHP;

    public int days = 7;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EndDay()
    {
        if (playerHP.CurrentHealth > 50.0f) {
            playerHP.DealDamage(50.0f);
            days -= 1;
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndDayScript : MonoBehaviour {

    public int days = 7;

	// Use this for initialization
	void Start () {

	}

    public void EndDay()
    {
        if (GameController.instance.currentHp > 50.0f) {
            GameController.instance.currentHp -= 50.0f;
            days -= 1;
        }
    }
}

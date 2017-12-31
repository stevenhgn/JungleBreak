using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfScript : MonoBehaviour {
    public PopUpWindow WolfPopUp;
    public string message;
    private int count = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        while (count < 1)
        {
            WolfPopUp.Show(message);
            count += 1;
        }
    }
}

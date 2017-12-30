using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfScript : MonoBehaviour {
    public PopUpWindow WolfPopUp;
    public string message;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        WolfPopUp.Show(message);
    }
}

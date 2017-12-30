using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopUpWindow : MonoBehaviour {
    public GameObject window;
    public Text dialougeText;

	// Use this for initialization
	public void Show(string message) {
        dialougeText.text= message; 
        //StopAllCoroutines();
        //StartCoroutine(TypeSentence(dialougeText.text));

        window.SetActive(true);
		
	}
	
	// Update is called once per frame
	public void Hide () {
        window.SetActive(false);
	}

    /*
    IEnumerator TypeSentence (string sentence) {
        dialougeText.text = " ";
        foreach (char letter in sentence.ToCharArray()) {
            dialougeText.text += letter;
            yield return null;
        }
    }
    */
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuNumberScript : MonoBehaviour {
    public Sprite number1;
    public Sprite number2;
    public Sprite number3;
    public Sprite number4;
    private List<Sprite> numbers = new List<Sprite>();
    private int index = 0;

	// Use this for initialization
	void Start () {
        numbers.Add(number1);
        numbers.Add(number2);
        numbers.Add(number3);
        numbers.Add(number4);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = numbers[index];
        index++;
        if(index > 3) {
            index = 0;
        }
    }
}

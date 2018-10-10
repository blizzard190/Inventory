using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour {

    public int number = 0;
	
	// Update is called once per frame
	public int Counts (int max) {
        if(number == max)
        {
            number = max;
        }
        else
        {
            number++;
        }
        return number;
	}

    public void MinCount()
    {
        number -= 1;
        Text numbers = this.GetComponent<Text>();
        if (number == 0)
        {
            numbers.text = " ";
        }
        else
        {
            numbers.text = number.ToString();
        }
    }
}

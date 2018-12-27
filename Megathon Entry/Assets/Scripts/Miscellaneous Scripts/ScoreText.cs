using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreText : MonoBehaviour {

    public Text score;
    public int par = 4;

    private int box = 0;

	void Start () {
		
	}
	
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            box += 1;
        }

        score.text = "Box Opened:" + (box + 1)/2 + "     Par: " + par;
	}
}

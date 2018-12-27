using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class VictoryPlatform : MonoBehaviour {

    public Text win;

    private void Start()
    {
        win.text = "";
    }

    void OnCollisionEnter () {
        win.text = "You're alive! For now...";
	}
}

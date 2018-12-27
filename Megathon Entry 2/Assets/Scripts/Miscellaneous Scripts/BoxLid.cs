using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLid : MonoBehaviour {

    private bool isClosed = false;
    private bool turnUpNow = false;
    private bool turnDownNow = false;
    public float Rotation;
    public float holdTime;
    private float stopTime = 0;

    void Start () {
		
	}

    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && isClosed == false && Time.time > stopTime)
        {
            stopTime = Time.time + holdTime;
            transform.Rotate(0.0f, 0.0f, Rotation * Time.deltaTime);
            isClosed = true;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && isClosed == true && Time.time > stopTime)
        {
            stopTime = Time.time + holdTime;
            transform.Rotate(0.0f, 0.0f, -Rotation * Time.deltaTime);
            isClosed = false;
        }
	}
}

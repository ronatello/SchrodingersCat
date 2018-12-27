using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweepingPlatform : MonoBehaviour {

    public float Rotation;
	
	void FixedUpdate () {
        transform.Rotate(0.0f, 0.0f, Rotation * Time.deltaTime);
	}
}

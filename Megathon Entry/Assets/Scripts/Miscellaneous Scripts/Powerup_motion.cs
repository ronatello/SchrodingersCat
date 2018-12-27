using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup_motion : MonoBehaviour {
    public float x_rot_speed;
    public float y_rot_speed;
    public float z_rot_speed;

	void Update () {
        transform.Rotate(new Vector3(x_rot_speed, y_rot_speed, z_rot_speed) * Time.deltaTime);
    }
}
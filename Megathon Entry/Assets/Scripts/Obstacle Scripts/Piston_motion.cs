using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piston_motion : MonoBehaviour {
    public float y_speed_up;
    public float y_speed_down;
    public float y_top_limit;
    public float y_bottom_limit;
    public float y_down_time;
 
    private float y_current_velocity;
    private float can_go_up_now = 0;
    
    void Start () {

    }
	
	void FixedUpdate () {
        // Check bounds
        if (transform.position.y >= y_top_limit)
        {
            y_current_velocity = -1.0f * y_speed_down;
            can_go_up_now = Time.time + y_down_time;
        }
        else if (transform.position.y <= y_bottom_limit && Time.time < can_go_up_now)
        {
            y_current_velocity = 0.0f;
        }
        else if (transform.position.y <= y_bottom_limit && Time.time >= can_go_up_now)
        {
            y_current_velocity = y_speed_up;
        }

        // Update pos
        transform.position += new Vector3(0.0f, y_current_velocity, 0.0f) * Time.deltaTime;
    }
}
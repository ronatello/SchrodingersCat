using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

    public float speed;
    private Rigidbody rigidbody;

    private int Death = 0;

    public float jumpUp;
    private bool isGrounded = false;

    void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate() {

        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        rigidbody.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true)
        {
            rigidbody.AddForce(new Vector3(0.0f, jumpUp, 0.0f));
            isGrounded = false;
        }

    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningScript : MonoBehaviour {

    public GameObject PlayerLight;
    private float prevTime = 0;

    void DestroyObjectDelayed()
    {
        Destroy(gameObject, 3);
    }

    private void Update()
    {
        if(Time.time > prevTime)
        {
            DestroyObjectDelayed();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            Destroy(PlayerLight);
        }
    }
}

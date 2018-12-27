using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour {

    public GameObject hazard;
    public Vector3 spawnValues;
    private float prevTime;

    void Start()
    {
        spawnWaves();
    }

    private void Update()
    {
        if(Time.time > prevTime)
        {
            spawnWaves();
            prevTime = Time.time + 6;
        }
    }

    void spawnWaves()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);

        Instantiate(hazard, spawnPosition, new Quaternion(0,0,0,1));
    }
}
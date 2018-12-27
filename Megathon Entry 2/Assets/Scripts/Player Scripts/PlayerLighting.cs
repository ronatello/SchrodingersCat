using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLighting : MonoBehaviour {

    public GameObject player;

	void FixedUpdate () {
        transform.position = new Vector3(player.transform.position.x + 0.3f, player.transform.position.y + 1, -3.0f);
	}
}

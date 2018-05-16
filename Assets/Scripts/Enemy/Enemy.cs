using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float moveSpeed = 25.0f;

    [SerializeField]
    float xOff, yOff, zOff;

    [SerializeField]
    Transform thePlayer;

    Rigidbody rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(thePlayer);
        //transform.position += Vector3.forward * Time.deltaTime * moveSpeed;

        transform.LookAt(new Vector3(thePlayer.position.x + xOff, thePlayer.position.y + yOff, thePlayer.position.z + zOff));
        rb.velocity = transform.forward * moveSpeed;

        Vector3 pos = transform.position;
        pos.y = -3.0f;
        transform.position = pos;
    }
}

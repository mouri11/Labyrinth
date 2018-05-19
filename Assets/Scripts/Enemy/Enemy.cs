using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    private float moveSpeed = 5.0f;

    [SerializeField]
    float xOff, yOff, zOff;

    [SerializeField]
    Transform thePlayer;

    Rigidbody rb;

    private int currenthealth;
    private int maxHealth = 10;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        thePlayer = GameObject.FindGameObjectWithTag("Player").transform;
        if (thePlayer == null) {
            Debug.Log("No GameObject tagged Player");
        }

        currenthealth = maxHealth;
    }
	
	// Update is called once per frame
	void Update () {
        //transform.LookAt(thePlayer);
        //transform.position += Vector3.forward * Time.deltaTime * moveSpeed;

        transform.LookAt(new Vector3(thePlayer.position.x + xOff, thePlayer.position.y + yOff, thePlayer.position.z + zOff));

        if (playerInSight())
            rb.velocity = transform.forward * moveSpeed;

        Vector3 pos = transform.position;
        pos.y = -2.5f;
        transform.position = pos;
    }

    bool playerInSight()
    {
        // TODO: Implement this
        return Player.instance.isAlive();
        //return true;
    }

    public void TakeDamage(int damage)
    {
        currenthealth -= damage;
        if (currenthealth <= 0) {
            Die();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") {
            Player.instance.TakeDamage(200);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}

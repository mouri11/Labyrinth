using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public static Player instance;

    private int currentHealth, maxHealth;

	//Rigidbody rigidbody;
	Vector3 velocity;

    void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one Player in the scene");
        }
        else
        {
            instance = this;
        }
        maxHealth = 100;
        currentHealth = maxHealth;
    }

    void Start () {
	}

	void Update () {
		//velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * 10;

        Cursor.lockState = CursorLockMode.Locked;
    }

	void FixedUpdate() {
		//rigidbody.MovePosition (rigidbody.position + velocity * Time.fixedDeltaTime);
	}

    public bool isAlive()
    {
        Debug.Log(currentHealth);
        return currentHealth > 0;
    }
}

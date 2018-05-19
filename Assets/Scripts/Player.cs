using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public static Player instance;

    private int currentHealth, maxHealth;

	//Rigidbody rigidbody;
	Vector3 velocity;

    [SerializeField]
    Animation bloodAnim;

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
        /*
        Debug.Log("Playing the anim");
        bloodAnim.Play("deathAnim");
        */
    }

	void Update () {
		//velocity = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical")).normalized * 10;

        Cursor.lockState = CursorLockMode.Locked;

        /*
        if (Input.GetKeyDown(KeyCode.T))
            bloodAnim.Play("deathAnim");
            */
    }

	void FixedUpdate() {
		//rigidbody.MovePosition (rigidbody.position + velocity * Time.fixedDeltaTime);
	}

    public bool isAlive()
    {
        return currentHealth > 0;
    }

    public void TakeDamage(int amt)
    {
        if (!isAlive())
            return;
        currentHealth -= amt;
        if (currentHealth <= 0) {
            bloodAnim.Play("deathAnim");
            StartCoroutine(Retry());
        }
    }

    IEnumerator Retry()
    {
        yield return new WaitForSeconds(1.0f);
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene("GameName");
        Debug.Log("Restart");
    }
}

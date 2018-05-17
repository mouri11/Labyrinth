using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackTiMainMenu : MonoBehaviour {
	public AudioSource audio ;
	public void mainMenu(){
		audio.Play();
		SceneManager.LoadScene("GameName");


	}
}

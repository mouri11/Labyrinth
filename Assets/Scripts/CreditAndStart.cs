using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditAndStart : MonoBehaviour {
	public AudioSource audio ;
	public GameObject loadingscreen;
	public Text percentText;
	public Text gameText;
	public Color textcolor;

	public void StartButton(int sceneIndex){
		audio.Play();
		StartCoroutine (LoadAsynchronously (sceneIndex));
		}

	IEnumerator LoadAsynchronously(int sceneIndex){
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);

		loadingscreen.SetActive (true);
		while (!operation.isDone) {
			float progress = Mathf.Clamp01 (operation.progress/0.9f);
			percentText.text=progress*100f +"%";
			textcolor.a = progress;
			gameText.color = textcolor;
			yield return null;
		}
	}
	public void CreditButton(int sceneIndex){
		audio.Play();
		StartCoroutine (LoadAsynchronously (sceneIndex));
	}
}

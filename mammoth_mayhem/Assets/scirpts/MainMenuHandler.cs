using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void loadGameScene(){
		SceneManager.LoadScene ("GameScene");
	}

	public void quitGame(){
		Application.Quit ();
	}
}

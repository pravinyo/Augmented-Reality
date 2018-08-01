using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMenu : MonoBehaviour {
	public void greetings(){
		SceneManager.LoadScene("ARGreetings");
	}

	public void rotateCube(){
		SceneManager.LoadScene("RotateCubeScene");
	}

	public void exitApp(){
		Application.Quit();
		Debug.Log("Exit Button Pressed");
	}
}

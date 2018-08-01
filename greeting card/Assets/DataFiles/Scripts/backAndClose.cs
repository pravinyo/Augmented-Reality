using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class backAndClose : MonoBehaviour {

	public void backBtn(){
		SceneManager.LoadScene("MenuScene");
	}

	public void exitBtn(){
		Application.Quit();
		Debug.Log("Application Quit called");
	}
}

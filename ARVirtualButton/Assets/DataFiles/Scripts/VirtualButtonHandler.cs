using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtualButtonHandler : MonoBehaviour , IVirtualButtonEventHandler {

	public GameObject spherego, cubego;
	VirtualButtonBahaviour vbr;
	// Use this for initialization
	void Start () {
		vbr = GetComponentInChildren<VirtualButtonBahaviour>();
		vbr.RegisterEventHandler(this);
		cubego.SetActive(true);
		spherego.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb) { 
		cubego.SetActive(false);
		spherego.SetActive(true);
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb) {
		cubego.SetActive(true);
		spherego.SetActive(false);
	}
}

﻿using UnityEngine;
using System.Collections;

public class UnicornsInstantiator : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public GameObject particleFire;
	public GameObject particleWind;
	public GameObject particleWater;

	// Use this for initialization
	void Start () {
	
		//Instantiate the players
		player1 = (GameObject) Instantiate(player1, new Vector3(-8.5f,0,0), Quaternion.identity);
		player2 = (GameObject) Instantiate(player2, new Vector3(8.5f,0,0), Quaternion.identity);
		player2.GetComponent<GoToDirectionX> ().direction = "left";
		player2.transform.Rotate (new Vector3 (0, 180, 0));

		//Attaches the particles (based off customization)
		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1HornParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player1.transform.GetChild (2));	
			o.transform.position = player1.transform.GetChild(2).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player1.transform.GetChild (2));	
			o2.transform.position = player1.transform.GetChild(2).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player1.transform.GetChild (2));	
			o3.transform.position = player1.transform.GetChild(2).position;
			break;
		}

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1TailParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player1.transform.GetChild (1));	
			o.transform.position = player1.transform.GetChild(1).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player1.transform.GetChild (1));	
			o2.transform.position = player1.transform.GetChild(1).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player1.transform.GetChild (1));	
			o3.transform.position = player1.transform.GetChild(1).position;
			break;
		}

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2HornParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player2.transform.GetChild (2));	
			o.transform.position = player2.transform.GetChild(2).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player2.transform.GetChild (2));	
			o2.transform.position = player2.transform.GetChild(2).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player2.transform.GetChild (2));	
			o3.transform.position = player2.transform.GetChild(2).position;
			break;
		}

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2TailParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player2.transform.GetChild (1));	
			o.transform.position = player2.transform.GetChild(1).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player2.transform.GetChild (1));	
			o2.transform.position = player2.transform.GetChild(1).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player2.transform.GetChild (1));	
			o3.transform.position = player2.transform.GetChild(1).position;
			break;
		}

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

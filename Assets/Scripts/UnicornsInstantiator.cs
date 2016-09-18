using UnityEngine;
using System.Collections;

public class UnicornsInstantiator : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	public GameObject []players;

	public GameObject particleFire;
	public GameObject particleWind;
	public GameObject particleWater;

	// Use this for initialization
	void Start () {

		player1 = players [Random.Range(0,players.Length-1)];
		player2 = players [Random.Range(0,players.Length-1)];

		//Instantiate the players
		player1 = (GameObject) Instantiate(player1, new Vector3(-8.5f,-3f,0), Quaternion.identity);
		player2 = (GameObject) Instantiate(player2, new Vector3(8.5f,-3f,0), Quaternion.identity);
		player2.GetComponent<GoToDirectionX> ().direction = "left";
		player2.transform.Rotate (new Vector3 (0, 180, 0));

		//Attaches the particles (based off customization)
		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1HornParsed) {
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

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1TailParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player1.transform.GetChild (0));	
			o.transform.position = player1.transform.GetChild(0).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player1.transform.GetChild (0));	
			o2.transform.position = player1.transform.GetChild(0).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player1.transform.GetChild (0));	
			o3.transform.position = player1.transform.GetChild(0).position;
			break;
		}

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2HornParsed) {
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

		switch (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2TailParsed) {
		case 0:
			GameObject o = (GameObject)Instantiate (particleFire, player2.transform.GetChild (0));	
			o.transform.position = player2.transform.GetChild(0).position;
			break;
		case 1:
			GameObject o2 = (GameObject)Instantiate (particleWater, player2.transform.GetChild (0));	
			o2.transform.position = player2.transform.GetChild(0).position;
			break;
		case 2:
			GameObject o3 = (GameObject)Instantiate (particleWind, player2.transform.GetChild (0));	
			o3.transform.position = player2.transform.GetChild(0).position;
			break;
		}

		if (GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().CalculateCollision () == 2) {
			player2.GetComponent<Rigidbody2D> ().mass = 4;
			player2.GetComponent<GoToDirectionX> ().speed += .4f;
		} else {
			player1.GetComponent<Rigidbody2D> ().mass = 4;
			player1.GetComponent<GoToDirectionX> ().speed += .4f;
		}
		//	//TODO: do something so that the player 2 is actually stronger than player1
		}
	}
	


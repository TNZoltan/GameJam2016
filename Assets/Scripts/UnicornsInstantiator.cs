using UnityEngine;
using System.Collections;

public class UnicornsInstantiator : MonoBehaviour {

	public GameObject player1;
	public GameObject player2;

	// Use this for initialization
	void Start () {
	
		player1 = (GameObject) Instantiate(player1, new Vector3(-8.5f,0,0), Quaternion.identity);
		player2 = (GameObject) Instantiate(player2, new Vector3(8.5f,0,0), Quaternion.identity);
		player2.GetComponent<GoToDirectionX> ().direction = "left";


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

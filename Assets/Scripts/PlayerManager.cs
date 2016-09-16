using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {


	public void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().CalculateCollision ());
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

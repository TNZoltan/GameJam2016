using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {


	public void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log(GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().CalculateCollision ());
	}

	public void OnTriggerExit2D(Collider2D other)
	{
		GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().MatchEnd ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

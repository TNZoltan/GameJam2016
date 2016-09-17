using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour {


	public void OnCollisionEnter2D(Collision2D other)
	{
		GameObject.Find ("EndRoundThing").GetComponent<Inflater> ().locked = false;
		GameObject.Find ("EndRoundThing").GetComponent<Image> ().enabled = true;
		GameObject.Find ("EndRoundText").GetComponent<Text> ().enabled = true;
		GameObject.Find ("EndRoundText").GetComponent<Inflater> ().locked = false;
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (int.MaxValue/10000000,1));
	}

	public void OnTriggerExit2D(Collider2D other)
	{
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

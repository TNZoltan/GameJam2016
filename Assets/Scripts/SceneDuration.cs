using UnityEngine;
using System.Collections;
using System.Threading;
using UnityEngine.UI;

public class SceneDuration: MonoBehaviour {

	ChoicesHandler ch;
	public float timer = 6f;

	// Use this for initialization
	void Start () {
		ch = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ();
		int result = ch.CalculateCollision ();
		if (result != 0)
			GameObject.Find ("EndRoundText").GetComponent<Text> ().text = "player " + result + "\nwon the round";
		else
			GameObject.Find ("EndRoundText").GetComponent<Text> ().text = "It's a draw \nfor this round";
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			timer = 6f;
			ch.MatchEnd ();
		}
	}
}

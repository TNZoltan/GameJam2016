using UnityEngine;
using System.Collections;
using System.Threading;

public class SceneDuration: MonoBehaviour {

	ChoicesHandler ch;
	public float timer = 2.5f;

	// Use this for initialization
	void Start () {
		ch = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ();
		ch.CalculateCollision ();
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0)
			ch.MatchEnd ();
	}
}

using UnityEngine;
using System.Collections;

public class Inflater : MonoBehaviour {

	public bool locked = true;
	public float speed = .15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!locked) {
			GetComponent<SpriteRenderer> ().enabled = true;
			this.transform.localScale += new Vector3(speed,speed,0);
		}
	}
}

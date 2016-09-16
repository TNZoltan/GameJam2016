using UnityEngine;
using System.Collections;

public class GoToDirectionX : MonoBehaviour {

	public float speed;
	//left or right
	public string direction;

	void Start () {
		
	}
	
	void Update () {
		if (direction.Equals ("right"))
			transform.position = new Vector3 (transform.position.x + speed, transform.position.y);
		if (direction.Equals ("left"))
			transform.position = new Vector3 (transform.position.x - speed, transform.position.y);
	}
}

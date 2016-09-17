using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Inflater : MonoBehaviour {

	public bool locked = true;
	public float speed = .15f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!locked) {
			this.transform.localScale += new Vector3(speed,speed,0);
			if (name == "EndRoundThing") {
				Color temp = GetComponent<Image>().color;
				temp.a+=1;
				GetComponent<Image>().color = temp;

			}
		}
	}
}

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
			if (this.transform.localScale.x <= 1.7)
				this.transform.localScale += new Vector3(speed,speed,0);
			//if (name == "EndRoundThing" ) {
			//	Color temp = GetComponent<Image>().color;
			//	temp.a+=0.01f;
			//	GetComponent<Image>().color = temp;
			//}
		}
	}
}

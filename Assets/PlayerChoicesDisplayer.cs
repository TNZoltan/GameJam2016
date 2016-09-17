using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerChoicesDisplayer : MonoBehaviour {

	public GameObject p1horn;
	public GameObject p1tail;
	public GameObject p2horn;
	public GameObject p2tail;

	// Use this for initialization
	void Start () {
		p1horn.GetComponent<Text>().text += GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1Horn;	
		p1tail.GetComponent<Text>().text += GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player1Tail;	
		p2horn.GetComponent<Text>().text += GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2Horn;	
		p2tail.GetComponent<Text>().text += GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().player2Tail;	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

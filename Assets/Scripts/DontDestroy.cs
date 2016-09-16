using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour {

	public GameObject text1;
	public GameObject text2;

	// Use this for initialization
	void Start () {
		text1.GetComponent<Text>().text = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().scoreHandler.player1Score.ToString();
		text2.GetComponent<Text>().text = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().scoreHandler.player2Score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

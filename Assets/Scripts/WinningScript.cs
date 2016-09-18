using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinningScript : MonoBehaviour {
    ChoicesHandler ch;
	// Use this for initialization
	void Start () {
        ch = GameObject.Find("Choicehandler").GetComponent<ChoicesHandler>();
        if (ch.scoreHandler.player1Score > ch.scoreHandler.player2Score) {
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite =Resources.Load<Sprite>("p1background.jpg");
            GameObject.Find("WinText").GetComponent<Text>().text = "";
        } else {
            GameObject.Find("Background").GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("p2background.jpg"); ;
            GameObject.Find("WinText").GetComponent<Text>().text = "";
        }
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinningScript : MonoBehaviour {
    ChoicesHandler ch;
	// Use this for initialization
	void Start () {
            ch = GameObject.Find("ChoiceHandler").GetComponent<ChoicesHandler>();
            if (ch.scoreHandler.player1Score > ch.scoreHandler.player2Score) {
				GameObject.Find("Background").GetComponent<Image>().sprite = Resources.Load<Sprite>("p1background");
                GameObject.Find("WinText").GetComponent<Text>().text = "Congratulations Player 1, you won! \n You are the new king of Unicornland!";
            } else {
                GameObject.Find("Background").GetComponent<Image>().sprite = Resources.Load<Sprite>("p2background"); ;
                GameObject.Find("WinText").GetComponent<Text>().text = "Congratulations Player 2, you won! \n You are the new king of Unicornland!";
            }
        
    }
	
	// Update is called once per frame
	void Update () {
	}
}

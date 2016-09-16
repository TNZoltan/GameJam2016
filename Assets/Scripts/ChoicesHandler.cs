using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoicesHandler : MonoBehaviour {

	//those are the info we'll actually keep in the "gameplay" scene
	public string player1Horn, player1Tail;
	public string player2Horn, player2Tail;

	//just temporary info for easier data handling
	private string hornChoice, tailChoice;
	private int player;

	void Awake() {
		DontDestroyOnLoad(gameObject);
		player = 1;
	}

	public void SetHornChoice(string choice)
	{
		hornChoice = choice;
	}

	public void SetTailChoice(string choice)
	{
		tailChoice = choice;
	}

	public void DoneFunction() 
	{
		if (tailChoice != null && hornChoice != null) 
		{
			if (player == 1) {
				player1Horn = hornChoice;
				player1Tail = tailChoice;
				player++;
				SceneManager.LoadScene ("RockPaperScissors2");
			} else {
				player2Horn = hornChoice;
				player2Tail = tailChoice;
				SceneManager.LoadScene ("_MainScene");
			}
		}
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoicesHandler : MonoBehaviour {

	public ScoreHandler scoreHandler;

	//those are the info we'll actually keep in the "gameplay" scene
	public string player1Horn, player1Tail;
	public string player2Horn, player2Tail;

	//those are the info we'll actually keep in the "gameplay" scene
	public int player1HornParsed, player1TailParsed;
	public int player2HornParsed, player2TailParsed;

	//just temporary info for easier data handling
	private string hornChoice, tailChoice;
	private int player;

	//Used to avoid the collision function to be called more than once per collision
	private bool collisionDone = false;

	void Awake() {
		DontDestroyOnLoad(gameObject);
		player = 1;
		scoreHandler = new ScoreHandler ();
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
				collisionDone = false;
				SceneManager.LoadScene ("_MainScene");
			}
		}
	}

	public int CalculateCollision()
	{
		if (!collisionDone) {
			collisionDone = true;

			ParseData ();
	
			CleanTmpData ();

			return scoreHandler.CalculateCollision (player1HornParsed, player1TailParsed, player2HornParsed, player2TailParsed);
		}
		return -1;
	}

	//Rock = 0, Paper = 1, Scissors = 2
	private void ParseData()
	{
		player1HornParsed = ParseString (player1Horn);
		player1TailParsed = ParseString (player1Tail);

		player2HornParsed = ParseString (player2Horn);
		player2TailParsed = ParseString (player2Tail);
	}

	//TODO: adapt to colors instead of rps
	private int ParseString(string s)
	{
		if (s.Equals ("Rock"))
			return 0;
		else if (s.Equals ("Paper"))
			return 1;
		else //if(s.Equals("Scissors"))
			return 2;
	}
		
	public void CleanTmpData()
	{
		hornChoice = null;
		tailChoice = null;
	}

	public void MatchEnd()
	{
		if (scoreHandler.gameOver)
			Debug.Log ("It's over.");
		else {
			SceneManager.LoadScene ("RockPaperScissors");
		}
	}
}

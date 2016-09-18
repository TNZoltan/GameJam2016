using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChoicesHandler : MonoBehaviour {

	public int roundWinner = -1;

	public int spriteInfoHorn1, spriteInfoHorn2;
	public int spriteInfoTail1, spriteInfoTail2;

	public ScoreHandler scoreHandler;

	//those are the info we'll actually keep in the "gameplay" scene
	public string player1Horn, player1Tail;
	public string player2Horn, player2Tail;

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
		SceneManager.LoadScene ("RockPaperScissors");
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
				hornChoice = null;
				tailChoice = null;
				spriteInfoHorn1 = GameObject.Find ("UnicornShowcase").GetComponent<PlayerManager> ().horn;
				spriteInfoTail1 = GameObject.Find ("UnicornShowcase").GetComponent<PlayerManager> ().tail;
				SceneManager.LoadScene ("RockPaperScissors2");
			} else {
				player2Horn = hornChoice;
				player2Tail = tailChoice;
				collisionDone = false;
				player = 1;
				ParseData ();
				spriteInfoHorn2 = GameObject.Find ("UnicornShowcase").GetComponent<PlayerManager> ().horn;
				spriteInfoTail2 = GameObject.Find ("UnicornShowcase").GetComponent<PlayerManager> ().tail;
				SceneManager.LoadScene ("_MainScene");
			}
		}
	}

	public int CalculateCollision()
	{
		if (!collisionDone) {
			collisionDone = true;

			//ParseData ();
	
			CleanTmpData ();
			roundWinner = scoreHandler.CalculateCollision (player1HornParsed, player1TailParsed, player2HornParsed, player2TailParsed);
		}		
		return roundWinner;

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
		if (s.Equals ("Fire"))
			return 0;
		else if (s.Equals ("Water"))
			return 1;
		else //if(s.Equals("Wind"))
			return 2;
	}
		
	public void CleanTmpData()
	{
		hornChoice = null;
		tailChoice = null;
	}

	public void MatchEnd()
	{
		if (scoreHandler.gameOver) {
			//Applause
			GetComponent<AudioSource> ().Play ();
			scoreHandler.player1Score = 0;
			scoreHandler.player2Score = 0;
			scoreHandler.gameOver = false;
			SceneManager.LoadScene ("MainMenu");
		}
		else {
			collisionDone = false;
			SceneManager.LoadScene ("RockPaperScissors");
		}
	}
}

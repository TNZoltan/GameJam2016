using UnityEngine;
using System.Collections;

public class ScoreHandler {

	int player1Score = 0;
	int player2Score = 0;

	int tempScore1 = 0;
	int tempScore2 = 0;

	public bool gameOver = false;
	public int winner = 0;

	//Rock = 0, Paper = 1, Scissors = 2

	public void rps(int player1, int player2)
	{
		switch (player1) {
		case 0:
			//if(player2 == 0)
			//	nothing
			if (player2 == 1)
				tempScore2++;
			if (player2 == 2)
				tempScore1++;
			break;
		case 1:
			if (player2 == 0)
				tempScore1++;
			//if (player2 == 1)
			//	nothing
			if (player2 == 2)
				tempScore2++;
			break;
		case 2:
			if (player2 == 0)
				tempScore2++;
			if (player2 == 1)
				tempScore1++;
			//if (player2 == 2)
			//	nothing
			break;
		}
	}

	public int CalculateCollision(int player1Horn, int player1Tail, int player2Horn, int player2Tail)
	{
		int result;

		rps(player1Horn, player2Horn);
		rps(player1Tail, player2Tail);

		player1Score += tempScore1;
		player2Score += tempScore2;

		CheckGameEnd();

		if (tempScore1 > tempScore2)
			result = 1;
		else if (tempScore1 == tempScore2)
			result =  0;
		else //if (tempScore1 < tempScore2)
			result =  2;

		tempScore1 = 0;
		tempScore2 = 0;

		return result;
	}

	public void CheckGameEnd() 
	{
		if (player1Score >= 7 && player1Score > player2Score) {
			//Debug.Log ("player1Won");
			gameOver = true;
			winner = 1;
		}
		if (player2Score >= 7 && player2Score > player1Score) {
			//Debug.Log ("player2Won");
			gameOver = true;
			winner = 2;
		}
	}
}


	


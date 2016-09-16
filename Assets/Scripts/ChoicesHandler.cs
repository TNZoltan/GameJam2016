using UnityEngine;
using System.Collections;

public class ChoicesHandler : MonoBehaviour {

	public string hornChoice, tailChoice;

	public void SetHornChoice(string choice)
	{
		hornChoice = choice;
	}

	public void SetTailChoice(string choice)
	{
		tailChoice = choice;
	}
}

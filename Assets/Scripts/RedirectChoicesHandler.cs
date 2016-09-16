using UnityEngine;
using System.Collections;

public class RedirectChoicesHandler : MonoBehaviour {

	ChoicesHandler choicesHandler;

	public void Start()
	{
		choicesHandler = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ();
	}

	public void Done()
	{
		choicesHandler.DoneFunction ();
	}

	public void SetHornChoice(string choice)
	{
		choicesHandler.SetHornChoice (choice);
	}

	public void SetTailChoice(string choice)
	{
		choicesHandler.SetTailChoice (choice);
	}
}

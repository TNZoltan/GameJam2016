using UnityEngine;
using System.Collections;

public class RedirectChoicesHandler : MonoBehaviour {

	public UnicornShowcase unicornShowcase;
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
		unicornShowcase.SetHornParticle (choice);
	}

	public void SetTailChoice(string choice)
	{
		choicesHandler.SetTailChoice (choice);
		unicornShowcase.SetTailParticle (choice);
	}
}

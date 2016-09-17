using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MenuManager : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene ("StartingScene");
	}

	public void Rules()
	{
		Debug.Log ("We might just actually add a 'Rules' scene to teach people wow to play");
	}

	public void Quit()
	{
		Application.Quit ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

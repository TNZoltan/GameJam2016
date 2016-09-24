using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public void Play()
	{
		SceneManager.LoadScene ("StartingScene");
	}

	public void Rules()
	{
        if (GameObject.Find("instructions").GetComponent<Image>().enabled)
			GameObject.Find("instructions").GetComponent<Image>().enabled = false;
        else
			GameObject.Find("instructions").GetComponent<Image>().enabled = true;
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

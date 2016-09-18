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
        if (GameObject.Find("instructions").GetComponent<SpriteRenderer>().enabled)
            GameObject.Find("instructions").GetComponent<SpriteRenderer>().enabled = false;
        else
            GameObject.Find("instructions").GetComponent<SpriteRenderer>().enabled = true;
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

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour {

	public GameObject[] sprites;

	public GameObject currentSprite;

	public int horn=-1, tail=-1;

	//for easier identification of the coordinates based on tail and horn
	private GameObject[,] sprites2;

	public void OnCollisionEnter2D(Collision2D other)
	{
		GameObject.Find ("EndRoundThing").GetComponent<Inflater> ().locked = false;
		GameObject.Find ("EndRoundThing").GetComponent<Image> ().enabled = true;
		Color temp = GameObject.Find ("EndRoundThing").GetComponent<Image> ().color;
		temp.a=0;
		GameObject.Find ("EndRoundThing").GetComponent<Image> ().color =  temp;

		GameObject.Find ("EndRoundText").GetComponent<Text> ().enabled = true;
		GameObject.Find ("EndRoundText").GetComponent<Inflater> ().locked = false;
		if (GetComponent<GoToDirectionX>().direction == "right")
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (int.MaxValue/10000000,1));
		else
			GetComponent<Rigidbody2D> ().AddForce (new Vector2 (-int.MaxValue/10000000,1));
		GetComponent<AudioSource> ().Play ();
		GameObject.Find ("PlayersScores").GetComponent<DontDestroy> ().UpdateScoreGUI ();
	}

	public void OnTriggerExit2D(Collider2D other)
	{
	}

	// Use this for initialization
	void Start () {
		sprites = Resources.LoadAll<GameObject> ("players");
		if (SceneManager.GetActiveScene ().name.Equals ("_MainScene"))
		{
			if (transform.position.x < 6) {
				horn = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().spriteInfoHorn1;
				tail = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().spriteInfoTail1;
			} else {
				horn = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().spriteInfoHorn2;
				tail = GameObject.Find ("ChoiceHandler").GetComponent<ChoicesHandler> ().spriteInfoTail2;
			}
			Debug.Log (horn+" "+tail);

			sprites2 = new GameObject[3, 3];
			int i = 0;
			for (int j = 0; j<3; j++)
				for (int k = 0; k<3; k++)
					sprites2[j,k] = sprites [i++];

			SetSprite ();
		}
		else {
			currentSprite = (GameObject) GameObject.Instantiate (sprites [0], transform);
			currentSprite.transform.position = transform.position;
			if (transform.position.x > 6)
				transform.Rotate (new Vector3 (0, 180, 0));
			sprites2 = new GameObject[3, 3];
			int i = 0;
			for (int j = 0; j<3; j++)
				for (int k = 0; k<3; k++)
					sprites2[j,k] = sprites [i++];
		}
}

	public void GetButtonInput(string button)
	{
		switch (button) {
		case "Fire_horn":
			horn = 0;
			break;
		case "Wind_horn":
			horn = 1;
			break;
		case "Water_horn":
			horn = 2;
			break;
		case "Fire_tail":
			tail = 0;
			break;
		case "Wind_tail":
			tail = 1;
			break;
		case "Water_tail":
			tail = 2;
			break;
		}
	}

	public void SetSprite()
	{
		if (horn != -1 && tail != -1) {
			GameObject o = (GameObject) GameObject.Find ("Untitled-2_0");
			if (o != null)
				GameObject.Destroy (o);
			GameObject.Destroy (currentSprite);
			currentSprite = (GameObject)GameObject.Instantiate (sprites2 [horn, tail], transform);
			currentSprite.transform.position = transform.position;
			if (SceneManager.GetActiveScene ().name.Equals ("_MainScene") && (transform.position.x > 6) )
				transform.Rotate (new Vector3 (0, 180, 0));
			
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

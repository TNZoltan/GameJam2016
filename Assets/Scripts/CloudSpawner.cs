using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {

	public GameObject[] spawnPoint;
	public GameObject[] clouds;

	// Use this for initialization
	void Start () {
		foreach (GameObject g in spawnPoint) {
			if (Random.Range (0, 9)<=7) {
				Instantiate(clouds[Random.Range(0,clouds.Length-1)],g.transform);
				//GameObject o = (GameObject) Instantiate(clouds[Random.Range(0,clouds.Length-1)],g.transform);
				//float x = Random.Range (0.5f, 1.5f);
				//o.transform.localScale = new Vector3 (x,x,x);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

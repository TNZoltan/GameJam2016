using UnityEngine;
using System.Collections;

public class CloudSpawner : MonoBehaviour {

	public GameObject[] spawnPoint;
	public GameObject[] clouds;

	// Use this for initialization
	void Start () {
		foreach (GameObject g in spawnPoint) {
			if (Random.Range (0, 9)<6) {
				Instantiate(clouds[Random.Range(0,clouds.Length-1)],g.transform);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

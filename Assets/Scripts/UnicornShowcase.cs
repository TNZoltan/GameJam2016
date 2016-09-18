using UnityEngine;
using System.Collections;

public class UnicornShowcase : MonoBehaviour {

	//private GameObject hornPosition;
	//private GameObject tailPosition;

	public GameObject horn;
	public GameObject tail;

	public GameObject particleFire;
	public GameObject particleWind;
	public GameObject particleWater;

	private GameObject hornParticle = new GameObject ();
	private GameObject tailParticle = new GameObject ();

	//	public void Start() {
	//		hornPosition.transform.position = horn.transform.position;
	//		tailPosition.transform.position = tail.transform.position;
	//	}
	//
	//	public void Update() {
	//		if (hornParticle!=null && hornParticle.name.Contains ("Water")) {
	//			hornParticle.transform.position = hornParticle.transform.position + new Vector3 (0, 10, 0);
	//		} else if (hornParticle!=null){
	//			hornParticle.transform.position = hornPosition.transform.position;
	//		}
	//
	//	}

	public void SetHornParticle(string particle) 
	{
		GameObject.Destroy (tailParticle);
		switch (particle)
		{
		case "Fire":
			tailParticle = (GameObject)Instantiate (particleFire, tail.transform);	
			tailParticle.transform.position = tail.transform.position;
			break;
		case "Water":
			tailParticle = (GameObject)Instantiate (particleWater, tail.transform);	
			tailParticle.transform.position = tail.transform.position;
			break;
		case "Wind":
			tailParticle = (GameObject)Instantiate (particleWind, tail.transform);	
			tailParticle.transform.position = tail.transform.position;
			break;
		}
	}

	public void SetTailParticle(string particle) 
	{
		GameObject.Destroy (hornParticle);
		switch (particle)
		{

		case "Fire":
			hornParticle = (GameObject)Instantiate (particleFire, horn.transform);	
			hornParticle.transform.position = horn.transform.position;
			break;
		case "Water":
			hornParticle = (GameObject)Instantiate (particleWater, horn.transform);	
			hornParticle.transform.position = horn.transform.position;
			break;
		case "Wind":
			hornParticle = (GameObject)Instantiate (particleWind, horn.transform);	
			hornParticle.transform.position = horn.transform.position;
			break;
		}
	}

}

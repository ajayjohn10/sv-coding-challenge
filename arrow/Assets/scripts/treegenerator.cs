using UnityEngine;
using System.Collections;

public class treegenerator : MonoBehaviour {
	public GameObject[] trees;

	public Vector3[] position;
	public float repeatRate;


	private float seconds;

	// Use this for initialization


	void Start () {

		InvokeRepeating("Spawn", 0.0f, repeatRate);
	}



	// Update is called once per frame
	void Update () {

	}

	void Spawn( ){


			Quaternion instarotation;
		Vector3 instaposition;
		float randYrot = Random.Range (0.0f, 180.0f);
			int randomObj = Random.Range (0, trees.Length);
		int randomX = Random.Range (0, position.Length);
		instarotation = Quaternion.Euler (new Vector3(0,randYrot,0));


			GameObject instantiatedobject = Instantiate (trees [randomObj], position[randomX], instarotation) as GameObject;
		




	}

}

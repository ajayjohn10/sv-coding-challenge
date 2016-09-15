using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void endgame()
	{
		PlayerPrefs.SetInt ("score", 0);
		Application.Quit();


	}
}

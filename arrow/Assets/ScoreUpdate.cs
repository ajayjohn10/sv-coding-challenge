using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour {
	private static Text score;
	private int value;

	// Use this for initialization
	void Start () {
		score = gameObject.GetComponent<Text>(); 
		value=PlayerPrefs.GetInt ("score",0 );	
		score.text = "Score : "+value;
	}

	public static void reset(){
		score.text = "Score : "+0;
	
	}
	// Update is called once per frame
	void Update () {
	
	




	}

}

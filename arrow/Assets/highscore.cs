using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
	private Text score;
	
	
	// Use this for initialization
	void Start () {
		int highscore1=0;
		highscore1 = PlayerPrefs.GetInt ("high");
		score = gameObject.GetComponent<Text>(); 
		score.text = "HighScore : "+highscore1;

	}
	
	// Update is called once per frame
	void Update () {
		
		

		
		
	}
}

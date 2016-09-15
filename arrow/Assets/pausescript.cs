using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class pausescript : MonoBehaviour {
	private Text text;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> (); 

	}
	// Update is called once per frame
	void Update () {
	
	}

	public void pause(){

		if (Time.timeScale == 1.0f) {
			Time.timeScale = 0.0f;
				text.text = "Resume";
			}

		else
		{
			Time.timeScale = 1.0f;
			text.text = "Pause";
		}
	}
}

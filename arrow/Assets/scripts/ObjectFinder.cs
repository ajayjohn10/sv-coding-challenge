using UnityEngine;
using System.Collections;

public class ObjectFinder : MonoBehaviour {
	public static GameObject keyup,keydown,keyleft,keyright,ring,cam;
	// Use this for initialization
	void Start () {
	

		keyup = GameObject.FindGameObjectWithTag ("keyup");
		keydown = GameObject.FindGameObjectWithTag ("keydown");
		keyleft = GameObject.FindGameObjectWithTag ("keyleft");
		keyright = GameObject.FindGameObjectWithTag ("keyright");
		ring = GameObject.FindGameObjectWithTag ("ring");
		cam = GameObject.FindGameObjectWithTag ("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

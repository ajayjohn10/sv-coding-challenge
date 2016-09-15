using UnityEngine;
using System.Collections;

public class playClick : MonoBehaviour {
	public static GameObject playbutton,watchadbutton,keyup,keydown,keyright,keyleft,ring,cam,generator,highscore,exit,pause;
	// Use this for initialization
	private Animator anim;
	int cameraroll = Animator.StringToHash("gamestart");
	void Start () {
		ring = GameObject.FindGameObjectWithTag ("ring");
		ring.SetActive (false);
		generator = GameObject.FindGameObjectWithTag ("generator");
		generator.SetActive (false);


		keyup = GameObject.FindGameObjectWithTag ("keyup");
		keydown = GameObject.FindGameObjectWithTag ("keydown");
		keyleft = GameObject.FindGameObjectWithTag ("keyleft");
		keyright = GameObject.FindGameObjectWithTag ("keyright");
		pause = GameObject.FindGameObjectWithTag ("pause");
		exit = GameObject.FindGameObjectWithTag ("exitbutton");
		highscore = GameObject.FindGameObjectWithTag ("highscore");


		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		watchadbutton = GameObject.FindGameObjectWithTag ("watchad");
		playbutton = this.gameObject;

		
		keyup.SetActive (false);
		keydown.SetActive (false);
		keyright.SetActive (false);
		keyleft.SetActive (false);
		pause.SetActive (false);

		anim = cam.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	




	}


	public void OnClicker(){

		GameController.gameScore = 0;
		ScoreUpdate.reset ();
		watchadbutton.SetActive (false);
		highscore.SetActive (false);
		exit.SetActive (false);
		pause.SetActive (true);
		anim.SetTrigger(cameraroll);

		StartCoroutine (activateobj());
		//applcntmngr.SetActive (true);

	}

	IEnumerator activateobj(){

		yield return new WaitForSeconds(2);
		keyup.SetActive (true);
		keydown.SetActive (true);
		keyright.SetActive (true);
		keyleft.SetActive (true);
		ring.SetActive (true);
		generator.SetActive (true);
		playbutton.SetActive (false);




	}
}

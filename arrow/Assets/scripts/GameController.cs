using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameController : MonoBehaviour {
	public static float gamespeed,gameLife;
	public static float perfect,notperfect;
	public static int gameScore;

	public static GameObject ring,cameramain;
	public GameObject score;
	//public static Material ringtex;
	public static MeshRenderer ringmesh;
	public   Texture ringtextureperfect,ringtexturenormal,ringtexturewrong;
	public  Material ringmat;
	public Slider lifeslider;
	public static int highscore;
	public static int firstTimeLaunch;
	private Text text;

	//public void  perfectclick();


	// Use this for initialization

	void Start () {

		gameLife = 1;
		notperfect = 2.5f;
		perfect = 1.2f;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		cameramain = this.gameObject; 
		//ring = GameObject.FindGameObjectWithTag ("ring");

		text = score.GetComponent<Text>(); 

		//ringmesh=ring.GetComponent<MeshRenderer>();
		//ringmesh.enabled = false;



		//ringtextureperfect=Resources.Load("circle_perfect") as Texture;

		//Application.targetFrameRate = 300;
		gamespeed = -20.0f;
		obstacleGen.fireRate = 3.0f;







	}
	
	// Update is called once per frame
	void Update () {
	

			if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.LoadLevel(Application.loadedLevel);
		}

		if (gameScore==3){
			obstacleGen.fireRate=2.5f;
			gamespeed=-22.0f;

		}

		if (gameScore==5){
			obstacleGen.fireRate=1.5f;
				gamespeed=-27.0f;
		}
		if (gameScore==10){
			obstacleGen.fireRate=1.0f;
			gamespeed=-33.0f;
		}

	}

	public  void  perfectclick(){
//		Debug.Log("perfectclickcalled");
		gameScore += 1;
		ringmat.SetTexture ("_MainTex",ringtextureperfect);
		text.text = "Score : "+GameController.gameScore;
		StartCoroutine (changetextureback());

	}
	public  void  earlyclick(){
		//		Debug.Log("perfectclickcalled");

		ringmat.SetTexture ("_MainTex",ringtexturewrong);
		StartCoroutine (changetextureback());
		//lifeslider.value -= 0.25f;
		//gameLife -= 0.25f;
	}
	public  void  lateclick(){
		//		Debug.Log("perfectclickcalled");

		ringmat.SetTexture ("_MainTex",ringtexturewrong);
		StartCoroutine (changetextureback());
		//lifeslider.value -= 0.25f;
		//gameLife -= 0.25f;
		
	}
	public  void  die(){
		//		Debug.Log("perfectclickcalled");
		gameLife -= 1.0f;
		lifeslider.value -= 1.0f;
		if (gameLife <= 0.0f) {
		//	Debug.Log ("Gameover");
		//	Time.timeScale=0.0f;

			PlayerPrefs.SetInt ("score", gameScore);
			PlayerPrefs.Save ();
			highscore=0;
			highscore=PlayerPrefs.GetInt ("high", highscore);		
			if(gameScore>highscore){

				PlayerPrefs.SetInt ("high", gameScore);
				PlayerPrefs.Save ();
			}


			Application.LoadLevel(Application.loadedLevel);

		}

		
	}
	IEnumerator changetextureback(){
		yield return new WaitForSeconds(0.2f);
		ringmat.SetTexture ("_MainTex",ringtexturenormal);
	}


	void SettingsDefault ()
	{
		// first time playing?
		firstTimeLaunch = PlayerPrefs.GetInt ("FirstTime", firstTimeLaunch);
		if (firstTimeLaunch != 1) {
			// default high score values
			highscore = 0;
			
			// default audio settings
//			audioEnabled = 1;

			
			// change this toggle to 1
			// this means the app has run it's initial launch
			firstTimeLaunch = 1;
			// save the value for future launches
			PlayerPrefs.SetInt ("FirstTime", firstTimeLaunch);
			PlayerPrefs.Save ();
		} else {
			// check player prefs for current highscore and update;
			highscore = PlayerPrefs.GetInt ("HighScore");
			
			// default audio settings
		//	audioEnabled = PlayerPrefs.GetInt ("AudioEnabled");

		}
		

	
	}

}

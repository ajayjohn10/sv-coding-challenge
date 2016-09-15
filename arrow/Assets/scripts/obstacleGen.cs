using UnityEngine;
using System.Collections;

public class obstacleGen : MonoBehaviour {
	public GameObject[] arrows,rarrows;
	public GameObject enemylow;
	public GameObject enemyhigh;
	public Vector3 arrowpositon;
	public Vector3 arrowrotation;
	public Vector3 obspositon;
	public Vector3 obsrotation;

	private Quaternion arrowrotationq;
	private Quaternion obsrotationq;
	public static float fireRate=3.0f;
	private float nextFire = 0.0F;
	// Use this for initialization
	void Start () {
		//GameController.ringmesh.enabled = true;
		fireRate=3.0f;
		arrowrotationq	= Quaternion.Euler(arrowrotation);
		obsrotationq = Quaternion.Euler(obsrotation);
		StartCoroutine (initWait());

		//InvokeRepeating("generate", 0.0f, repeatRate);
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > nextFire){
			//Debug.Log("enterd function");
			nextFire = Time.time + fireRate;
			generateobs ();


	

		}


	}

	IEnumerator initWait(){
		yield return new WaitForSeconds(2);

	}


	void generateobs()
	{
		int obstacleType = Random.Range (0, 2);

		if(obstacleType==0){

			int arrowdir =Random.Range(0,8);
			 Instantiate (arrows[arrowdir],arrowpositon,arrowrotationq);
			 Instantiate (enemylow,obspositon,obsrotationq);


		}
		if(obstacleType==1){
			
			int arrowdir =Random.Range(0,8);
			 Instantiate (rarrows[arrowdir],arrowpositon,arrowrotationq);
			 Instantiate (enemyhigh,obspositon,obsrotationq);
			
			
		}


	}



}

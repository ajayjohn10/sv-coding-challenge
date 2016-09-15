using UnityEngine;
using System.Collections;

public class rightscript : MonoBehaviour {




	private bool right;
	private float positionx;
	private GameController gcr;
	//public Texture ringtextureperfect,ringtexturenormal;
	//public Material ringmaterial;
	// Use this for initialization
	void Start () {
		right = false;
	

		gcr=playClick.cam.GetComponent<GameController>();

	}
	
	// Update is called once per frame
	void Update () {

		right = false;

		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Stationary) {
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit = new RaycastHit();
				if (Physics.Raycast (ray,out hit,1000.0f)) {
					if(hit.collider.gameObject == playClick.keyright.gameObject)  {
						right=true;

					}



				}
			}
		}

		if (right==true) {



			positionx=transform.position.x;
			if(positionx>=GameController.perfect&&positionx<=GameController.notperfect){
				//Debug.Log("early");
				gcr.earlyclick();

				Destroy(this.gameObject);
			}
			if(positionx>-GameController.perfect&&positionx<GameController.perfect){
				//perfect();
				//GameController.perfectclick();

				//lDebug.Log("perfect");

				gcr.perfectclick();

				Destroy(this.gameObject);
			}
			if(positionx>=-GameController.notperfect&&positionx<=-GameController.perfect){

				gcr.lateclick();
				Destroy(this.gameObject);
				//Debug.Log("late");
			}


		}

		if(transform.position.x<-GameController.notperfect){
			
			gcr.die();
			Destroy(this.gameObject);
			
		}	

	}





}

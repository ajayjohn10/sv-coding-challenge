using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;

using UnityEngine.UI;

public class watchad : MonoBehaviour {
	public Slider lifeslider;
	void Awake() {
		if (Advertisement.isSupported) {
			Advertisement.Initialize ("50066");
		} else {
			Debug.Log("Platform not supported");
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		}

	public void showAdv(){

		if (Advertisement.IsReady ()&&GameController.gameLife!=2.0f) {
			
			Advertisement.Show (null, new ShowOptions {
				resultCallback = result => {
					
					switch(result)
					{
					case (ShowResult.Finished):
						
						GameController.gameLife=2.0f;
						lifeslider.value=2;
						break;
					case (ShowResult.Failed):
						
						break;
					case(ShowResult.Skipped):
						
						break;
					}
					
					
				}
			});
			
			
		} else {
			

			
		}
	}




}

using UnityEngine;
using System.Collections;

public class keytouch : MonoBehaviour {

	public Texture texture,textureoriginal;
	public Material mat;
	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
	
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began) {
				Ray ray = Camera.main.ScreenPointToRay (touch.position);
				RaycastHit hit = new RaycastHit();
				if (Physics.Raycast (ray,out hit,1000.0f)) {
					if(hit.collider.gameObject == this.gameObject)  {

						changetext();
						
					}
				
					
				}
			}

			if (touch.phase == TouchPhase.Ended) {
				changetextback();
			}



		}


	}

	void changetext(){

		mat.SetTexture ("_MainTex",texture);


	}
	void changetextback(){
		

		mat.SetTexture ("_MainTex",textureoriginal);
	}
}

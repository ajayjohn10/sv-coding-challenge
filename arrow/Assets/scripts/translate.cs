using UnityEngine;
using System.Collections;

public class translate : MonoBehaviour {
	public float movementSpeed;
	private Rigidbody rigid;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody> ();
		movementSpeed = GameController.gamespeed;
	}
	
	// Update is called once per frame
	void FixedUpdate() {

		
		rigid.velocity = new Vector3 (1, 0, 0) * movementSpeed;
		//transform.Translate(Vector3.left * movementSpeed * Time.deltaTime,Space.World);
		if (transform.position.x < -100.0f) {
		
			Destroy(this.gameObject);
		
		}
}
}
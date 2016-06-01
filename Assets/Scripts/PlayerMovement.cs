using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rg;
	private CarProperties cp;

	void Start () {
		rg = GetComponent<Rigidbody2D> ();	
		cp = GetComponent<CarProperties> ();
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		if (v != 0f) {
			doMovement (h, v);
		}
	}
	void doMovement(float h, float v){
		if (rg.velocity.magnitude < cp.maxSpeed) {
			rg.AddForce (transform);
		}
	}	
}

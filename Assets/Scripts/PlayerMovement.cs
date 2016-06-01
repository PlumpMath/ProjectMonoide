using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private Rigidbody2D rg;
	private CarProperties cp;

	void Start () {
		rg = GetComponent<Rigidbody2D> ();	
		cp = GetComponent<CarProperties> ();
		rg.drag = cp.weight;	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		if (v != 0f || rg.velocity.magnitude !=0f) {
			doMovement (-h, v);
		}
	}
	void doMovement(float h, float v){
		if (h != 0) {
			rg.transform.Rotate (new Vector3(0,0,h*cp.turnRate));
			Debug.Log (rg.rotation);

		}
		if (rg.velocity.magnitude < cp.maxSpeed) {
			rg.velocity = new Vector2(rg.velocity.magnitude*Mathf.Cos(rg.rotation)*v,rg.velocity.magnitude*Mathf.Sin(rg.rotation)*v);
		}
	}	
}

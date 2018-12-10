using UnityEngine;

public class HandMotion : MonoBehaviour {

	//Variable Declaration
	public float speed;
	private Rigidbody rb;
	private bool isAtRest = true;
	public bool IsAtRest
	{
		get {
			return isAtRest;
		}
	}

	void Start() {

		rb = GetComponent<Rigidbody>();

	}
	
	void FixedUpdate () {

		if (gameObject.tag == "Left")
			if (Input.GetButton("LHandRight")) {
				isAtRest = false;
				rb.velocity = Vector3.right * speed;
			}
			else if (Input.GetButton("LHandLeft")) {
				isAtRest = false;
				rb.velocity = Vector3.left * speed;
			}
			else {
				isAtRest = true;
				rb.velocity = Vector3.zero;
			}
		else
			if (Input.GetButton("RHandRight")) {
				isAtRest = false;
				rb.velocity = Vector3.right * speed;
			}
			else if (Input.GetButton("RHandLeft")) {
				isAtRest = false;
				rb.velocity = Vector3.left * speed;
			}
			else {
				isAtRest = true;
				rb.velocity = Vector3.zero;
			}

	}
}

using UnityEngine;

public class LeftHandMotion : MonoBehaviour {

	//Variable Declaration
	public float speed;
	private Rigidbody rb;

	void Start() {

		rb = GetComponent<Rigidbody>();

	}
	
	void FixedUpdate () {

		if (Input.GetButton("LHandRight"))
			rb.velocity = Vector3.right * speed;
		else if (Input.GetButton("LHandLeft"))
			rb.velocity = Vector3.left * speed;
		else
			rb.velocity = Vector3.zero;
	}
}

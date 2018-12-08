using UnityEngine;

public class RightHandMotion : MonoBehaviour {

	//Variable Declaration
	public float speed;
	private Rigidbody rb;

	void Start() {

		rb = GetComponent<Rigidbody>();

	}
	
	void FixedUpdate () {

		if (Input.GetButton("RHandRight"))
			rb.velocity = Vector3.right * speed;
		else if (Input.GetButton("RHandLeft"))
			rb.velocity = Vector3.left * speed;
		else
			rb.velocity = Vector3.zero;

	}
}

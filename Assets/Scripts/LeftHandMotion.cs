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
			rb.velocity = Vector3.right * speed;//transform.Translate(speed * Vector3.right * Time.deltaTime);
		else if (Input.GetButton("LHandLeft"))
			rb.velocity = Vector3.left * speed;//transform.Translate(speed * Vector3.left * Time.deltaTime);
		else
			rb.velocity = Vector3.zero;
	}
}

using UnityEngine;

public class HandMotion : MonoBehaviour {							//This class handles all hand motion and controls between both hands

	//Variable Declaration
	private float speed;											//Speed of the hands
	private Rigidbody rb;											//Their rigidbody
	private bool isAtRest = true;									//A boolean that states whether a hand is currently not moving
	public bool IsAtRest											//IsAtRest property making it read-only
	{
		get {
			return isAtRest;
		}
	}

	void Start() {

		//Initialization
		speed = 6;
		rb = GetComponent<Rigidbody>();

	}
	
	void FixedUpdate () {

		if (gameObject.tag == "Left")								//First decides which hand this object is on
			if (Input.GetButton("LHandRight")) {					//Then decides which directional button for that hand was pressed and will apply the appropriate velocity
				isAtRest = false;
				rb.velocity = Vector3.right * speed;
			}
			else if (Input.GetButton("LHandLeft")) {
				isAtRest = false;
				rb.velocity = Vector3.left * speed;
			}
			else {													//If no button was pressed, then the hand is at rest and the velocity is set to the zero vector
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

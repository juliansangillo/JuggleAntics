using UnityEngine;

public class WallReflect : MonoBehaviour {							//This class handles reflecting the ball back into the playing field if it hits one of the walls

	private Rigidbody rb;											//The rigidbody of the ball that collided with this wall
	private float G;												//The acceleration of the ball due to gravity
	private float distance;											//Distance to bounce back to
	private float time;												//Time to bounce back in
	private Vector3 veloc;											//New Vector3 veocity of the ball

	void Start() {
		
		//Initialization
		G = 9.81f;
		time = 1f;

	}

	void OnCollisionEnter(Collision collision) {					//This is called when the ball collides with the wall
		
		if (collision.gameObject.tag == "Ball") {
			rb = collision.gameObject.GetComponent<Rigidbody>();	//Sets the rigidbody
			
			if(gameObject.tag == "Left") {
				distance = -1.5f - gameObject.transform.position.x;	//Calculates the distance
				veloc.x = distance / time;							//Calculates the velocity in the x
				veloc.y = 0.5f * G * time;							//calculates the velocity in the y
			}
			else {
				distance = gameObject.transform.position.x - 1.5f;
				veloc.x = -(distance / time);
				veloc.y = 0.5f * G * time;
			}
			veloc.z = 0;											//Disables velocity in the z by setting it to zero
			
			rb.velocity = veloc;									//Sets the velocity of the ball
			collision.gameObject.GetComponent<AudioSource>().Play();//Plays the balls collision audio source
		}

	}
	
}

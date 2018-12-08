using UnityEngine;

public class WallReflect : MonoBehaviour {

	private Rigidbody rb;
	private float G;
	private float distance;
	private float time;
	private Vector3 veloc;

	void Start() {

		G = 9.81f;
		time = 1f;

	}

	void OnCollisionEnter(Collision collision) {
		
		if (collision.gameObject.tag == "Ball") {
			rb = collision.gameObject.GetComponent<Rigidbody>();
			
			if(gameObject.tag == "Left") {
				distance = -1.5f - gameObject.transform.position.x;
				veloc.x = distance / time;
				veloc.y = 0.5f * G * time;
			}
			else {
				distance = gameObject.transform.position.x - 1.5f;
				veloc.x = -(distance / time);
				veloc.y = 0.5f * G * time;
			}
			veloc.z = 0;
			
			rb.velocity = veloc;
			
		}

	}
	
}

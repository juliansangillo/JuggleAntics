using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballFab;
	public GameObject spawner;
	Rigidbody rb;
	public int force;

	// Use this for initialization
	void Start () {
		spawnBall();
	}
	
	void spawnBall() {

		GameObject ball = Instantiate(ballFab, spawner.transform.position, spawner.transform.rotation);
		rb = ball.GetComponent<Rigidbody>();
		rb.AddForce(spawner.transform.forward * force);

	}
}

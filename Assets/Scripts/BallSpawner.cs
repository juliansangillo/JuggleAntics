using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballFab;
	public GameObject[] spawn;

	// Use this for initialization
	void Start () {
		spawnBall();
	}
	
	void spawnBall() {

		int index = Random.Range(0, spawn.Length);

		Instantiate(ballFab, spawn[index].transform.position, spawn[index].transform.rotation);
	}
}

using UnityEngine;

public class End : MonoBehaviour {

	public GameObject[] obj;
	public GameObject can;
	private static GameObject o1;
	private static GameObject o2;
	private static GameObject o3;
	private static GameObject canvas;
	private bool isPlaying;

	void Start() {

		isPlaying = true;
		o1 = obj[0];
		o2 = obj[1];
		o3 = obj[2];
		canvas = can;

	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag == "Ball") {
			Destroy(col.gameObject);

			if (isPlaying) {
				isPlaying = false;
				gameOver();
			}
		}

	}

	public static void gameOver() {

		disableScene();
		enableUI();

	}

	static void disableScene() {

		o1.GetComponent<LeftHandMotion>().enabled = false;
		o1.GetComponent<Rigidbody>().velocity = Vector3.zero;
		o2.GetComponent<RightHandMotion>().enabled = false;
		o2.GetComponent<Rigidbody>().velocity = Vector3.zero;
		o3.GetComponent<BallSpawner>().enabled = false;

	}

	static void enableUI() {

		canvas.SetActive(true);

	}

}

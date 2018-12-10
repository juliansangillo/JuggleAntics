using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour {

	private static GameObject ballCount;
	private static GameObject scoreCount;
	private static int ball;
	private static int score;

	// Use this for initialization
	void Start () {
		
		ballCount = GameObject.Find("Ball Counter");
		scoreCount = GameObject.Find("Score Counter");

		ball = 0;
		score = 0;

	}

	public static void incrementBall() {

		ball++;
		ballCount.GetComponent<TextMeshProUGUI>().text = ball.ToString();

	}

	public static void incrementScore() {

		score += 10;
		scoreCount.GetComponent<TextMeshProUGUI>().text = score.ToString();

	}

	public static int getBalls() {

		return ball;

	}

	public static int getScore() {

		return score;

	}

}

using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour {											//This class manages the ball count and current score

	private static GameObject ballCount;										//Counter to display balls
	private static GameObject scoreCount;										//Counter to display current score
	private static int ball;													//Number of balls currently in scene
	private static int score;													//Current score

	void Start () {
		
		//Initialization
		ballCount = GameObject.Find("Ball Counter");
		scoreCount = GameObject.Find("Score Counter");

		ball = 0;
		score = 0;

	}

	public static void incrementBall() {										//Increment's number of balls by 1 and displays new value

		ball++;
		ballCount.GetComponent<TextMeshProUGUI>().text = ball.ToString();

	}

	public static void incrementScore() {										//Increment's current score by 10 and displays new value

		score += 10;
		scoreCount.GetComponent<TextMeshProUGUI>().text = score.ToString();

	}

	public static int getBalls() {												//Gets number of balls

		return ball;

	}

	public static int getScore() {												//Gets current score

		return score;

	}

}

using UnityEngine;
using TMPro;

public class End : MonoBehaviour {										//This class handles the end game. It provides a gameOver function that will get called in both end game conditions. This class specifically handles OutOfBounds

	public GameObject init;												//Initiator object that can enable and disable scene activity
	public GameObject endPanel;											//UI panel that display gameOver screen
	private bool isPlaying;												//Boolean that states whether the game is still being played and end game has not been reached yet

	void Start() {

		//Initialization
		isPlaying = true;

	}

	void OnTriggerEnter(Collider col) {									//This is called when the OutOfBounds trigger is activated

		if (col.gameObject.tag == "Ball") {
			Destroy(col.gameObject);									//Destroys the ball that tripped the trigger
			gameOver();													//Enter end game
		}

	}

	public void gameOver() {											//Disables scene and ends the game

		if (isPlaying) {												//If the game has not already end
			isPlaying = false;
			init.GetComponent<Initiator>().disableScene();

			endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "";
			if (Counter.getScore() > DataManager.highScore.Score) {			//Saves new highScore if there is one
				DataManager.Save(Counter.getBalls(), Counter.getScore());
				endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text += "NEW ";
			}

			endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text += "High Score-> Balls: " + DataManager.highScore.Balls + " Score: " + DataManager.highScore.Score;

			enableUI();														//Displays the endPanel
		}

	}

	void enableUI() {													//Sets the endPanel to active

		endPanel.SetActive(true);

	}

}

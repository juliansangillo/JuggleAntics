using UnityEngine;
using TMPro;

public class InitHighScore : MonoBehaviour {			//This class initializes the high score text in the main menu with the values of the high score

	public GameObject ballUI;							//UI for the balls in the high score
	public GameObject scoreUI;							//UI for the highest score thus far

	void Start() {

		//Initialization
		ballUI.GetComponent<TextMeshProUGUI>().text += DataManager.highScore.Balls;
		scoreUI.GetComponent<TextMeshProUGUI>().text += DataManager.highScore.Score;

	}

}

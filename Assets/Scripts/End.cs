using UnityEngine;
using TMPro;

public class End : MonoBehaviour {

	public GameObject init;
	public GameObject endPanel;
	private bool isPlaying;

	void Start() {

		isPlaying = true;

	}

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag == "Ball") {
			Destroy(col.gameObject);

			if (isPlaying) {
				gameOver();
			}
		}

	}

	public void gameOver() {

		isPlaying = false;
		init.GetComponent<Initiator>().disableScene();

		if (Counter.getScore() > DataManager.highScore.Score) {
			DataManager.Save(Counter.getBalls(), Counter.getScore());
			endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "NEW ";
		}
		else
			endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text = "";

		endPanel.GetComponent<Transform>().GetChild(1).gameObject.GetComponent<TextMeshProUGUI>().text += "High Score-> Balls: " + DataManager.highScore.Balls + " Score: " + DataManager.highScore.Score;

		enableUI();

	}

	void enableUI() {

		endPanel.SetActive(true);

	}

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainOption : MonoBehaviour {

	void changeToJuggle() {

		SceneManager.LoadScene(1, LoadSceneMode.Single);

	}

	public void chooseOption(int mode) {

		BallMode.set(mode);
		changeToJuggle();

	}

	public void quitGame() {

		Application.Quit();

	}

}

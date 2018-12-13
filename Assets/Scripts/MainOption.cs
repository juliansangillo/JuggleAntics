using UnityEngine;
using UnityEngine.SceneManagement;

public class MainOption : MonoBehaviour {					//This class provides the functionalities needed by the UI in the main menu

	void changeToJuggle() {									//Loads the juggleScene

		SceneManager.LoadScene(1, LoadSceneMode.Single);	

	}

	public void chooseOption(int mode) {					//Sets the selected ball mode before switching scenes

		BallMode.set(mode);
		changeToJuggle();

	}

	public void quitGame() {								//Exits the whole game wwhen called by onClick event

		Application.Quit();

	}

}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {							//This class handles the loading command back to main menu when game ends and an onClick event trigger activates

	public void changeToMain() {								//This loads the main menu when called by an onClick event
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}

}

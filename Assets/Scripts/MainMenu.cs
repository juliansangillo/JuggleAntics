using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void changeToMain() {
		SceneManager.LoadScene(0, LoadSceneMode.Single);
	}

}

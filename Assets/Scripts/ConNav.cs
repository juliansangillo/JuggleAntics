using UnityEngine;
using UnityEngine.SceneManagement;

public class ConNav : MonoBehaviour {							//This class provides public functions for the button navigation in the controls scene

	public void play() {										//This brings us to the juggleScene

		GameObject theme;

		if (theme = GameObject.Find("Menu Theme"))				//Destroys the menu theme music if one exists
			Destroy(theme);

		SceneManager.LoadScene(2, LoadSceneMode.Single);		//Loads the juggleScene

	}

	public void back() {										//This brings us back to the menu scene

		SceneManager.LoadScene(0, LoadSceneMode.Single);		//Loads the menu scene

	}

}

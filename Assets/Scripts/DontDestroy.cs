using UnityEngine;

public class DontDestroy : MonoBehaviour {

	void Awake() {

		if (GameObject.FindWithTag("Theme")) {		//It is capable for duplicates of this object to appear because of DontDestroyOnLoad
			Destroy(this.gameObject);				//This Awake checks if another object just like it already exists and has been marked with the tag "Theme"
		}											//If yes, destroy this duplicate
		else {										//else, then this object is currently unique and will be our main theme audio source (i.e. we don't want our above code to destroy this one). So we will mark it with the tag "Theme"
			gameObject.tag = "Theme";
		}

	}

	void Start () {

		DontDestroyOnLoad(this.gameObject);			//Ensures that the menu theme object is not destroyed when moving between Menu and Controls scenes

	}
	
}

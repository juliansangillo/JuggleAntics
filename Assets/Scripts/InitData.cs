using System.IO;
using UnityEngine;

public class InitData : MonoBehaviour {				//This class will attempt to load the saved high score data on a scene's awake
													//If this fails, then it will save a new file with the default values of 0 and 0
	void Awake() {

		//Initialization
		if (DataManager.highScore == null && !DataManager.Load())
			DataManager.Save(0, 0);

		if (BallMode.get() == 0)
			BallMode.set(1);

	}
	
}

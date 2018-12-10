using System.IO;
using UnityEngine;
using TMPro;

public class Init : MonoBehaviour {

	public GameObject ballUI;
	public GameObject scoreUI;

	void Awake() {

		if (File.Exists(Application.dataPath + DataManager.path))
			DataManager.Load();
		else
			DataManager.Save(0, 0);

	}

	void Start() {

		ballUI.GetComponent<TextMeshProUGUI>().text += DataManager.highScore.Balls;
		scoreUI.GetComponent<TextMeshProUGUI>().text += DataManager.highScore.Score;

	}

}

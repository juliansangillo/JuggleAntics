using System.Collections;
using System.IO;
using UnityEngine;
using TMPro;

public class Initiator : MonoBehaviour {								//This class handles the initial countdown and start sequence of the juggleScene

	public GameObject initPanel;										//The panel that displays initial countdown
	public GameObject[] obj;											//Objects directly influencing scene
	private IEnumerator initSeq;										//IEnumerator needed for a coroutine of initSequence

	void Start () {

		//Initialization
		initSeq = initSequence();
		StartCoroutine(initSeq);

	}

	void enableScene() {												//This enables the scene for play by enabling functionality of the influencing objects

		obj[0].GetComponent<HandMotion>().enabled = true;
		obj[1].GetComponent<HandMotion>().enabled = true;
		obj[2].GetComponent<BallSpawner>().enabled = true;

	}
	
	public void disableScene() {										//This disables the functionality of influencing objects, thus disabling the scene

		obj[0].GetComponent<HandMotion>().enabled = false;
		obj[0].GetComponent<Rigidbody>().velocity = Vector3.zero;
		obj[1].GetComponent<HandMotion>().enabled = false;
		obj[1].GetComponent<Rigidbody>().velocity = Vector3.zero;
		obj[2].GetComponent<BallSpawner>().enabled = false;
		obj[3].GetComponent<Counter>().enabled = false;

	}

	IEnumerator initSequence() {										//This performs the initial countdown and enables the scene when countdown has passed

		yield return new WaitForSeconds(1f);
		for (int i = 3; i > 0; i--) {
			initPanel.GetComponentInChildren<TextMeshProUGUI>().text = i.ToString();
			yield return new WaitForSeconds(1f);
		}
		initPanel.GetComponentInChildren<TextMeshProUGUI>().text = "Start!!";
		yield return new WaitForSeconds(1f);
		initPanel.SetActive(false);
		enableScene();

	}

}

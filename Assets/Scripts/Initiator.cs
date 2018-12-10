using System.Collections;
using System.IO;
using UnityEngine;
using TMPro;

public class Initiator : MonoBehaviour {

	public GameObject initPanel;
	public GameObject[] obj;
	private IEnumerator initSeq;

	void Start () {

		initSeq = initSequence();
		StartCoroutine(initSeq);

	}

	void enableScene() {

		obj[0].GetComponent<HandMotion>().enabled = true;
		obj[1].GetComponent<HandMotion>().enabled = true;
		obj[2].GetComponent<BallSpawner>().enabled = true;

	}
	
	public void disableScene() {

		obj[0].GetComponent<HandMotion>().enabled = false;
		obj[0].GetComponent<Rigidbody>().velocity = Vector3.zero;
		obj[1].GetComponent<HandMotion>().enabled = false;
		obj[1].GetComponent<Rigidbody>().velocity = Vector3.zero;
		obj[2].GetComponent<BallSpawner>().enabled = false;
		obj[3].GetComponent<Counter>().enabled = false;

	}

	IEnumerator initSequence() {

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

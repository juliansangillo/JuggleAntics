using System.Collections;
using UnityEngine;
using TMPro;

public class BallSpawner : MonoBehaviour {

	public GameObject ballFab;
	public GameObject[] spawn;
    public GameObject[] countdown;
    private GameObject countManage;
    private GameObject ball;
    private IEnumerator cor;
    private int scoreBar = 200;

    // Use this for initialization
    void Start () {

        countManage = GameObject.Find("Counter Manager");
        BallMode.set(1); //Uncomment when developing this scene
		cor = startSpawnSequence(BallMode.get());
        StartCoroutine(cor);
        cor = spawnSequence();
        StartCoroutine(cor);

	}

    void spawnBall() {

        int index = Random.Range(0, spawn.Length);
        ball = Instantiate(ballFab, spawn[index].transform.position, spawn[index].transform.rotation);
        cor = startCountdown(index, ball);
        StartCoroutine(cor);

    }

    IEnumerator startSpawnSequence(int balls) {

        for (int i = 0; i < balls; i++) {
            spawnBall();
            yield return new WaitForSeconds(1f);
        }

    }

    IEnumerator spawnSequence() {

        yield return new WaitUntil(() => Counter.getScore() == scoreBar);
        spawnBall();
        scoreBar += 200;

    }

    IEnumerator startCountdown(int index, GameObject ball) {

        countdown[index].SetActive(true);
        for (int i = 3; i >= 0; i--) {
            countdown[index].GetComponent<TextMeshProUGUI>().text = i.ToString();
            yield return new WaitForSeconds(1f);
        }
        countdown[index].SetActive(false);
        if (countManage.GetComponent<Counter>().enabled)
            Counter.incrementBall();
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ;
        countdown[index].GetComponent<TextMeshProUGUI>().text = "3";

    }

}

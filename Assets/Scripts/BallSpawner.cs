using System.Collections;
using UnityEngine;
using TMPro;

public class BallSpawner : MonoBehaviour {          //Spawns balls at the start of gameplay and frequently during gameplay

	public GameObject ballFab;                      //Ball Prefab Object
	public GameObject[] spawn;                      //Ball Spawn Positions
    public GameObject[] countdown;                  //Ball Drop Countdowns
    public Material[] material;                     //Ball Material Choices
    private GameObject countManage;                 //Counter Manager
    private GameObject ball;                        //Ball Instance
    private IEnumerator cor;                        //IEnumerator to be used for Coroutines
    private int scoreBar = 100;                     //Amount of points the player needs for the next ball to spawn

    void Start () {

        //Initialization
        countManage = GameObject.Find("Counter Manager");
		cor = startSpawnSequence(BallMode.get());
        StartCoroutine(cor);
        cor = spawnSequence();
        StartCoroutine(cor);

	}

    void spawnBall() {                              //Spawns ball at a random spawner with a random material and begins its drop countdown

        int index = Random.Range(0, spawn.Length);
        int matIndex = Random.Range(0, material.Length);
        ball = Instantiate(ballFab, spawn[index].transform.position, spawn[index].transform.rotation);
        ball.GetComponent<MeshRenderer>().material = this.material[matIndex];
        cor = startCountdown(index, ball);
        StartCoroutine(cor);

    }

    IEnumerator startSpawnSequence(int balls) {     //Rate of first spawning

        for (int i = 0; i < balls; i++) {
            spawnBall();
            yield return new WaitForSeconds(1f);
        }

    }

    IEnumerator spawnSequence() {                   //Rate of following spawns

        while(true) {
            yield return new WaitUntil(() => Counter.getScore() == scoreBar);
            spawnBall();
            scoreBar += 100;
        }

    }

    IEnumerator startCountdown(int index, GameObject ball) {    //Countdown till spawned ball is dropped

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

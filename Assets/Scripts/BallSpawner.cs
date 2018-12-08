using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballFab;
	public GameObject[] spawn;

    public static int bcount = 0;



    // Use this for initialization
    void Start () {
		spawnBall();
	}

void spawnBall() {

	int index = Random.Range(0, spawn.Length);

	Instantiate(ballFab, spawn[index].transform.position, spawn[index].transform.rotation);
}

//	for(int i=0;i < 5; i++)
	//{

        GameObject ball = Instantiate(ballFab, spawn.transform.position, spawn.transform.rotation);
        rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(spawn.transform.forward * force);
        bcount++;

        Debug.Log("bcount is " + bcount);
//	}


    }



}

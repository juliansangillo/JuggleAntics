using UnityEngine;
using System.IO; //Delete Before Final Build

public class Balldirection : MonoBehaviour {

    //References
    public GameObject ballFab;
    private GameObject countManage;
    private Rigidbody rb;
    //Constants
    private float G;
    //Variables
    private float distance;
    private float timeOfFlight;
    private Vector3 veloc;

    //Dummy Awake Function for Developer
    void Awake() {

        if (File.Exists(Application.dataPath + DataManager.path))
			DataManager.Load();
		else
			DataManager.Save(0, 0);

    }
    //Delete Before Final Build

    void Start(){

        countManage = GameObject.Find("Counter Manager");
        G = 9.81f;

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Ball") {
            if (countManage.GetComponent<Counter>().enabled)
                Counter.incrementScore();
            rb = collision.gameObject.GetComponent<Rigidbody>();
            
            distance = 3;
            timeOfFlight = 1.7f;
            if (gameObject.GetComponent<HandMotion>().IsAtRest) {
                distance /= 2f;
                timeOfFlight += 0.2f;
            }

            veloc.x = distance / timeOfFlight;
            veloc.y = 0.5f * G * timeOfFlight;
            veloc.z = 0;

            if (gameObject.tag == "Right") {
                veloc.x = -veloc.x;
                if (Input.GetButton("RHandRight"))
                    veloc.x = -veloc.x;
            }
            else if (gameObject.tag == "Left" && Input.GetButton("LHandLeft"))
                veloc.x = -veloc.x;

            rb.velocity = veloc;
        }

    }

}

using UnityEngine;

public class Balldirection : MonoBehaviour {

    //References
    public GameObject ballFab;
    private Rigidbody rb;
    //Constants
    private float G;
    //Variables
    private int score;
    private float distance;
    private float timeOfFlight;
    private Vector3 veloc;

    void Start(){

        score = 0;
        G = 9.81f;

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Ball") {
            score += 10;
            rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezePositionZ;

            distance = 3;
            timeOfFlight = 1.7f;
            if (gameObject.GetComponent<Rigidbody>().velocity == Vector3.zero) {
                distance /= 1.5f;
                timeOfFlight += 0.1f;
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

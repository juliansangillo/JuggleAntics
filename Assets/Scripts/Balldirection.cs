using UnityEngine;

public class Balldirection : MonoBehaviour {
    
    //References
    public GameObject ballFab;                  //Ball Prefab Object
    private GameObject countManage;             //Counter Manager Object
    private Rigidbody rb;                       //Ball's Rigidbody
    //Constants
    private float G;                            //Constant for gravity
    //Variables
    private float distance;                     //Distance to travel on x-axis
    private float timeOfFlight;                 //Time the ball should remain in the air for
    private Vector3 veloc;                      //The ball's new velocity to be applied

    void Start() {

        //Initialization
        countManage = GameObject.Find("Counter Manager");
        G = 9.81f;

    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.tag == "Ball") {                            //Runs when the ball is thrown by a hand
            if (countManage.GetComponent<Counter>().enabled)
                Counter.incrementScore();                                   //Increments the score
            rb = collision.gameObject.GetComponent<Rigidbody>();            //Gets the rigidbody
            
            distance = 3;                                                   //Sets distance and time of flight
            timeOfFlight = 1.7f;
            if (gameObject.GetComponent<HandMotion>().IsAtRest) {
                distance /= 2f;                                             //Adjust distance and time of flight if hand is at rest
                timeOfFlight += 0.2f;
            }

            veloc.x = distance / timeOfFlight;                              //Calculates velocity in x and y directions and sets the z to zero
            veloc.y = 0.5f * G * timeOfFlight;
            veloc.z = 0;

            if (gameObject.tag == "Right") {
                veloc.x = -veloc.x;                                         //Adjusts the direction of the velocity in respect to the hand that is being used
                if (Input.GetButton("RHandRight"))
                    veloc.x = -veloc.x;                                     //Adjusts the direction of the velocity in respect to the direction that hand is moving
            }
            else if (gameObject.tag == "Left" && Input.GetButton("LHandLeft"))
                veloc.x = -veloc.x;

            rb.velocity = veloc;                                            //Applies the velocity
            collision.gameObject.GetComponent<AudioSource>().Play();        //Plays throw sound
        }

    }

}

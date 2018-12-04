using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balldirection : MonoBehaviour {
    
    private Rigidbody rb;
    public static int score;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag == "Ball") 
        {                                      
            rb = collision.gameObject.GetComponent<Rigidbody>();

            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            
            if (this.name == "Left Hand")
            { 
                rb.AddForce(Vector3.right * 2, ForceMode.Impulse);

                score += 10;
                

            }

            else if (this.name == "Right hand")
            { 
                rb.AddForce(Vector3.left * 2, ForceMode.Impulse);
                score += 10;
                


            }
            Debug.Log(score);
        }
    }

}

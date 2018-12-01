using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balldirection : MonoBehaviour {
    
    private Rigidbody rb;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Ball(Clone)") // Ball alone wasn't working but Ball(Clone) Does
        {
            Debug.Log("This Works");

            //  rb = GetComponent<Rigidbody>();
            //  rb = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationZ;
            


            // Destroy(collision.gameObject); // destroy's the ball just for practice

        }
    }

    
}

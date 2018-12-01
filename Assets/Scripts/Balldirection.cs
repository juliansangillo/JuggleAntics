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
        if(collision.gameObject.tag == "Ball") // I forgot that tags existed! It just occured to me that a tag would work better
        {                                      // here since the name of each clone could be different.
            rb = collision.gameObject.GetComponent<Rigidbody>();
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
        }
    }

    
}

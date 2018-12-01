using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balldirection : MonoBehaviour {
    
    private Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball") // I forgot that tags existed! It just occured to me that a tag would work better
        {                                      // here since the name of each clone could be different.
            rb = collision.gameObject.GetComponent<Rigidbody>();

            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            
            if (this.name == "Left Hand")
                rb.AddForce(Vector3.right * 2, ForceMode.Impulse);
            else
                rb.AddForce(Vector3.left * 2, ForceMode.Impulse);
        }
    }

}

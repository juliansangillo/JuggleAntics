using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBool : MonoBehaviour {

	public static bool LH;
	public static bool RH;

	// Use this for initialization
	void Start () {
		LH=false;
		RH=false;
	

	}

	void OnCollisionEnter(Collision col)
	{	//col.gameObject.name == "Left Hand"
		
		
		 if(col.gameObject.name == "Left Hand" && LH == true) 
			{  
				Debug.Log("Game Over, You used Left Hand twice");
			}		
	
		else if(col.gameObject.name == "Right hand" && RH == true) 
		{  
			Debug.Log("Game Over, You used Right Hand twice");
		} 
		
		else if(col.gameObject.name == "Left Hand")
		{

			if(this.tag == "Ball") {
		  	Debug.Log("1 True for Left");
			LH = true;
			RH = false;
						}
		}
		

		else if(col.gameObject.name == "Right hand") 
		{  	Debug.Log("1 True for Right");
			RH = true;
			LH = false;
		}

		
			


	}

	// Update is called once per frame
	void Update () {

	}
}

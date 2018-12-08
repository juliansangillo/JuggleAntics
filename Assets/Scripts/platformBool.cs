using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBool : MonoBehaviour {

	private bool LH;
	private bool RH;

	// Use this for initialization
	void Start () {

		LH=false;
		RH=false;
	
	}

	void OnCollisionEnter(Collision col)
	{
		
		if((col.gameObject.name == "Left Hand" && LH == true) || (col.gameObject.name == "Right hand" && RH == true)) 
		{  
			End.gameOver();
		}
		else if(col.gameObject.name == "Left Hand")
		{
			LH = true;
			RH = false;
		}
		else if(col.gameObject.name == "Right hand") 
		{  
			RH = true;
			LH = false;
		}

	}

}

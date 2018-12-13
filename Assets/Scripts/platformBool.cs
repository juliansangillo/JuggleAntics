using UnityEngine;

public class platformBool : MonoBehaviour {			//This class handles the alternative means of reaching the end game, if the same ball hit the same hand twice in a row

	private GameObject bounds;						//The OutOfBounds trigger collider
	private bool LH;								//Boolean for the left hand
	private bool RH;								//Boolean for the right hand

	void Start () {

		//Initialization
		bounds = GameObject.Find("OutOfBounds");
		LH=false;
		RH=false;
	
	}

	void OnCollisionEnter(Collision col) 			//Is called upon a collision with a hand
	{									 			//First checks if it collided with either hand and their respective bools are also true (meaning this is the second time that ball hit that hand) and calls the gameOver as a result

		if((col.gameObject.name == "Left Hand" && LH == true) || (col.gameObject.name == "Right hand" && RH == true)) 
		{  
			bounds.GetComponent<End>().gameOver();
		}
		else if(col.gameObject.name == "Left Hand")	//Otherwise, checks if it just collided with the hand and then flips boolean values
		{
			LH = true;
			RH = false;
		}
		else if(col.gameObject.name == "Right hand") 
		{  
			LH = false;
			RH = true;
		}

	}

}

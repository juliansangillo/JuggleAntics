using UnityEngine;

public class LeftHandMotion : MonoBehaviour {

	//Variable Declaration
	public float speed;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton("LHandRight"))
			transform.Translate(speed * Vector3.right * Time.deltaTime);
		else if (Input.GetButton("LHandLeft"))
			transform.Translate(speed * Vector3.left * Time.deltaTime);
		
	}
}

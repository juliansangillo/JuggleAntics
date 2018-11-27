using UnityEngine;

public class RightHandMotion : MonoBehaviour {

	//Variable Declaration
	public float speed;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButton("RHandRight"))
			transform.Translate(speed * Vector3.right * Time.deltaTime);
		else if (Input.GetButton("RHandLeft"))
			transform.Translate(speed * Vector3.left * Time.deltaTime);
		
	}
}

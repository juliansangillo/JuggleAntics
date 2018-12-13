using UnityEngine;

public class DontDestroy : MonoBehaviour {

	void Start () {

		Object.DontDestroyOnLoad(this.gameObject);			//Ensures that the menu theme object is not destroyed when moving between Menu and Controls scenes

	}
	
}

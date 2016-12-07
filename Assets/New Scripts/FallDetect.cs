using UnityEngine;
using System.Collections;

public class FallDetect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameVariables.checkpoint = new Vector3 (0, 3, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -10) {
			transform.position = GameVariables.checkpoint;
		}
	}
}

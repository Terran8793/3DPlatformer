using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {

	void OnTriggerEnter(Collider collider)
	{
		if (collider.gameObject.name == "player") 
		{
			GameVariables.checkpoint = transform.position;
		}
	}
}

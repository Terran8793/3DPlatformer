using UnityEngine;
using System.Collections;

public class Sprint : MonoBehaviour {

	float walkSpeed, runSpeed;
	CharacterMotor cm;
	bool isRunning;

	// Use this for initialization
	void Start () {
		cm = gameObject.GetComponent<CharacterMotor> ();
		walkSpeed = cm.movement.maxForwardSpeed;
		runSpeed = walkSpeed * 4;
	}

	void SetRunning(bool isRunning)
	{
		this.isRunning = isRunning;
		cm.movement.maxForwardSpeed = isRunning ? runSpeed : walkSpeed;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.LeftShift))
			SetRunning (true);
		if (Input.GetKeyUp (KeyCode.LeftShift))
			SetRunning (false);
	}
}

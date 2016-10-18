using UnityEngine;
using System.Collections;

public class SpeedBoost : MonoBehaviour {

	//public Ball ball;
	float boostEnergy = 5, maxBoostEnergy = 5;
	float rollSpeed, boostSpeed;
	CharacterMotor cm;
	bool isBoosting;

	// Use this for initialization
	void Start () {
		cm = gameObject.GetComponent<CharacterMotor> ();
		rollSpeed = cm.movement.maxForwardSpeed;
		boostSpeed = rollSpeed * 4;
	}

	void SetBoosting(bool isBoosting)
	{
		this.isBoosting = isBoosting;
		cm.movement.maxForwardSpeed = isBoosting ? boostSpeed : rollSpeed;
	}


	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftShift))
			SetBoosting (true);
		if (Input.GetKeyUp (KeyCode.LeftShift))
			SetBoosting (false);
	
		if (isBoosting) 
		{
			boostEnergy -= Time.deltaTime;
			if (boostEnergy < 0) 
			{
				boostEnergy = 0;
				SetBoosting (false);
			}
		} 
		else if (boostEnergy < maxBoostEnergy) 
		{
			boostEnergy += Time.deltaTime;
		}
	}
}

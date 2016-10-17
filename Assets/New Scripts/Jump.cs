using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	private Rigidbody controller;

	public float jumpHeight;  

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
			if (Input.GetKeyDown (KeyCode.Space)) 
			{
				controller.velocity = new Vector3(0,jumpHeight,0);
			}
	}
}

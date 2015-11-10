//Author:	Hugh Healy
//Date:		10/11/2015
//Time:		18:00
//Script:	Player Controller
//Notes:	Functioning perfectly

using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float currentSpeed = 0.0f;
	public float walkSpeed = 30f;
	public float runSpeed = 50f;

	void Start()
	{
		currentSpeed = walkSpeed;
	}

	void Update()
	{
		//Movement
		if(Input.GetAxis("Horizontal") < 0.1f)
		{
			Debug.Log("Left");

			MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), 0));
		}

		if(Input.GetAxis("Horizontal") > 0.1f)
		{
			Debug.Log("Right");

			MoveCharacter(new Vector2(Input.GetAxis("Horizontal"), 0));
		}

		if(Input.GetAxis("Vertical") > 0.1f)
		{
			Debug.Log("Up");

			MoveCharacter(new Vector2(0, Input.GetAxis("Vertical")));
		}

		if(Input.GetAxis("Vertical") < 0.1f)
		{
			Debug.Log("Down");

			MoveCharacter(new Vector2(0, Input.GetAxis("Vertical")));
		}

		//Jump
		if(Input.GetButtonDown("Jump"))
		{
			Debug.Log("Jump Pressed");
			//Accelerate
			currentSpeed = runSpeed;
		}

		if(Input.GetButtonUp("Jump"));
		{
			Debug.Log("Jump Released");
			//Decellerate
			currentSpeed = walkSpeed;
		}
	}

	void MoveCharacter(Vector2 axis)
	{
		transform.Translate (axis * currentSpeed * Time.deltaTime);
	}
}
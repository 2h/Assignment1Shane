﻿//Author:	Hugh Healy
//Date:		12/11/2015
//Time:		11:50
//Script:	Foe Movement
//Notes:	Functioning

using UnityEngine;
using System.Collections;

public class FoeMovement : MonoBehaviour {
	
	public Transform wayPointOne;
	public Transform wayPointTwo;
	public Transform currentWayPoint;
	
	public Transform playerPosition;
	
	public float speed = 20f;

	//Used as a reference to the 'detect' variable in the DetectionZoe Script
	private static int detectMV;
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveFoe ();
	}
	
	public void moveFoe()
	{
		//assigning local variable a value equal to that of the 'detect' variable in the DetectionZone class
		detectMV = DetectionZone.detect;
		
		if (detectMV == 1) 
		{
			Debug.Log("Detected");
			//Transform.Position - The position of the transform in world space.
			//MoveTowards - Moves a point current towards target - (current, target, speed)
			
			playerPosition = GameObject.Find ("Player").transform;
			
			currentWayPoint = playerPosition;
			
			transform.position = Vector2.MoveTowards (transform.position, currentWayPoint.position, speed * Time.deltaTime);
			//transform.position = Vector2.MoveTowards (transform.position, playerPosition, speed * Time.deltaTime);
			
		}
		if (detectMV == 0) 
		{
			Debug.Log("Not Detected");
			
			//Transform.Position - The position of the transform in world space.
			//MoveTowards - Moves a point current towards target - (current, target, speed)
			transform.position = Vector2.MoveTowards (transform.position, currentWayPoint.position, speed * Time.deltaTime);
			
			//Vector2.Distance - Returns the distance between a and b. Below - (current Transform, wayPoint)
			float distanceToWayPointOne = Vector2.Distance (transform.position, wayPointOne.position);
			//Debug.Log("Distance to WayPoint 1 is " + distanceToWayPointOne);
			
			float distanceToWayPointTwo = Vector2.Distance (transform.position, wayPointTwo.position);
			//Debug.Log ("Distance to Waypoint 2 is " + distanceToWayPointTwo);
			
			//Check to see if object has arrived at the current way point. 
			//If the distance to the target waypoint is zero, the object has arrived.
			//Now set the waypoint to the next waypoint in the cycle
			if (distanceToWayPointOne == 0.0f) 
			{
				currentWayPoint = wayPointTwo;
			}
			
			if (distanceToWayPointTwo == 0.0f) 
			{
				currentWayPoint = wayPointOne;
			}
		}
	}
}
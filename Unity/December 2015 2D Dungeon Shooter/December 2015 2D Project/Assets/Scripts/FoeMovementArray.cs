using UnityEngine;
using System.Collections.Generic;

public class FoeMovementArray : MonoBehaviour {

	//Storing a list of WayPoints
	public List<Transform> wayPoints = new List<Transform>();

	//The current target WayPoint
	public Transform currentWayPoint;

	//Storing the Waypoints identity
	public int WayPointNumber = 0;

	public float speed = 4.0f;

	//Used in creating a delay at each Patrol Point
	public float timeToWait = 3.0f;
	public float timeSpentWaiting = 0f;


	public Transform playerPosition;
	//Used as a reference to the 'detect' variable in the DetectionZoe Script
	public int detectMV;

	// Use this for initialization
	void Start () {
	
		//randomize speed
		//speed = Random.Range(15f,20f);
		//timeToWait = Random.Range (1f, 4f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		moveEnemy();
	}

	public void moveEnemy()
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
			Debug.Log ("Not Detected");

			//Reset the current Way Pointusing last stored current drawn frm the list
			currentWayPoint = wayPoints [WayPointNumber];

			//check the distance between the game object and the patrol point
			float distanceToCurrent = Vector2.Distance (transform.position, currentWayPoint.position);

			//On reaching the wayPoint
			if (distanceToCurrent == 0) 
			{
				if (WayPointNumber != wayPoints.Count - 1) {
					//step to the bext point in the list
					WayPointNumber++;
					//set the next Waypoint 
					currentWayPoint = wayPoints [WayPointNumber];
				} else {
					WayPointNumber = 0;
					currentWayPoint = wayPoints [WayPointNumber];
				}
			}

			//Move towards current waypoint
			transform.position = Vector2.MoveTowards (transform.position, currentWayPoint.position, speed * Time.deltaTime);
		}


	}
}
			
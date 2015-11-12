//Author:	Hugh Healy
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
	public float speed = 40f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		moveFoe ();
	}

	public void moveFoe()
	{
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
	
/*	void onTriggerEnter(Collider other)
	{
		Debug.Log("Object Entered the Trigger");
	}

	void onTriggerStay(Collider other)
	{
		Debug.Log("Object is within the Trigger");
	}

	void onTriggerExit(Collider other)
	{
		Debug.Log ("Objext exited the Trigger");
	}
		//		if(thingWeCollidedWith.gameObject.CompareTag("Player"))
//		{
//			Debug.Log ("Player Entered Detection Zone" + thingWeCollidedWith.gameObject.tag);
//			//Debug.Log ("Player Postion" + thingWeCollidedWith.transform.position);
//			transform.position = Vector2.MoveTowards (transform.position, thingWeCollidedWith.transform.position, speed * Time.deltaTime);
//		}
*/

}

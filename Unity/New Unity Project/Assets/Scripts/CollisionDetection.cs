//Author:	Hugh Healy
//Date:		11/11/2015
//Time:		13:00
//Script:	Object Collision Script
//Notes:	Functioning perfectly
using UnityEngine;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

	public void OnCollisionEnter2D(Collision2D thingWeCollideWith)
	{
		Debug.Log ("Collided with " + thingWeCollideWith.gameObject.tag);

		if(thingWeCollideWith.gameObject.CompareTag("Item"))
		{
			Destroy(thingWeCollideWith.gameObject);
		}
	}
}
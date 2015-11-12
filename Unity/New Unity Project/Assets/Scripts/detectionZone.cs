using UnityEngine;
using System.Collections;

public class detectionZone : MonoBehaviour {
			
	void onTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Object Entered the Trigger");
	}
	
	void onTriggerStay2D(Collider2D other)
	{
		Debug.Log("Object is within the Trigger");
	}
	
	void onTriggerExit2D(Collider2D other)
	{
		Debug.Log ("Objext exited the Trigger");
	}

//		if(thingWeCollidedWith.gameObject.CompareTag("Player"))
//		{
//			transform.position = Vector2.MoveTowards (transform.position, thingWeCollidedWith.transform.position, speed * Time.deltaTime);
//		}

}
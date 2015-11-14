using UnityEngine;
using System.Collections;

public class DetectionZone : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Object Entered the Trigger: " + other.gameObject.tag);
	}
	
	void onTriggerStay2D(Collider2D other)
	{
		Debug.Log("Object is within the Trigger" + other.gameObject.tag);
	}
	
	void onTriggerExit2D(Collider2D other)
	{
		Debug.Log ("Objext exited the Trigger" + other.gameObject.tag);
	}
}

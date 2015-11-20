using UnityEngine;
using System.Collections;

public class DetectionZone : MonoBehaviour {

	public FoeMovement Foe;

	//this int is used as a flag for detection
	//the value is pulled to the FoeMovement script
	public static int detect = 0;


	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			Debug.Log("Object Entered the Trigger: " + other.gameObject.tag);
			detect = 1;
		}
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("Object is within the Trigger: " + other.gameObject.tag);
			detect = 1;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("Objext exited the Trigger: " + other.gameObject.tag);
			detect = 0;
		}
	}
}
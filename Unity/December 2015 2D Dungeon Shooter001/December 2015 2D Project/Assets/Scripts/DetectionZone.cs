using UnityEngine;
using System.Collections;

public class DetectionZone : MonoBehaviour {

	//public FoeMovement Foe;

	//this int is used as a flag for detection
	//the value is pulled to the FoeMovement script
	public int detect = 0;

	public string parentName;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player"))
		{
			//Foe.detectMV = 1;

			parentName = gameObject.transform.parent.name;

			Debug.Log("Player Triggered the: " + parentName);

			detect = 1;
		}
	}
	
	void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("Player is within the Trigger of the: " + parentName);
			detect = 1;
		}
	}
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Player")) 
		{
			Debug.Log ("Player exited the Trigger of the : " + parentName);
			detect = 0;
		}
	}
}
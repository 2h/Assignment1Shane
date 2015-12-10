using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {
	
	public Transform newPlayerPosition;

	public string CurrentLevelName;

	void OnTriggerEnter2D(Collider2D transitionObject)
	{
		Debug.Log ("GameObject " + transitionObject.name);

		if (transitionObject.gameObject.tag == "Player") 
		{


			//change the position of the player to the spawn point of the level
			transitionObject.gameObject.transform.position = newPlayerPosition.position;

			//the camera is childed to the player so automatically follows
		}
	}

	//not currently used
	void getLevelName()
	{
		CurrentLevelName = Application.loadedLevelName;
		Debug.Log ("Level Name: " + CurrentLevelName);
	}
}

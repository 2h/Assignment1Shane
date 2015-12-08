using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour {

	public Transform newPlayerPosition;

	public string CurrentLevelName;

	void Updare()
	{
	
	}

	void OnTriggerEnter2D(Collider2D transitionObject)
	{
		Debug.Log ("GameObject " + transitionObject.name);

		if (transitionObject.gameObject.tag == "Player") 
		{
			Application.LoadLevel("Level002");
		}
	}

	void getLevelName()
	{
		CurrentLevelName = Application.loadedLevelName;
		Debug.Log ("Level Name: " + CurrentLevelName);
	}
}

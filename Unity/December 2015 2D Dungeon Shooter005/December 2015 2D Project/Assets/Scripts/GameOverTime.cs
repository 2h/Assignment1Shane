using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverTime : MonoBehaviour {

	//create a reference to the Timer script
	public Timer gameTime;

	//create a reference to the timeText in the inspector
	public Text timerText;

	public int completeTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameEndTime ();
	}

	void gameEndTime()
	{	
		completeTime = gameTime.intDuration;
			
		timerText.text = "Your Time Change: " + completeTime;

		//timeDuration += Time.deltaTime;
		//intDuration = (int)timeDuration;
		//Debug.Log ("Start Time: " + intDuration);
	}

}

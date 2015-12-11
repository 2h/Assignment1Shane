//Author:	Hugh Healy
//Date:		9/12/2015
//Time:		18:00
//Script:	Game Timer
//Notes:	Functioning

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	//public float timeStart;
	public float timeDuration;

	public int intDuration;

	public Text timerText;
	//public string timerFormatted;

	public void Start()
	{
		Awake ();
		//initiate to zero at start
		timerText.text = "Time: " + Time.time;
	}
	
	// Update is called once per frame
	void Update () 
	{
		setTimer ();
	}

	void setTimer()
	{

		timeDuration += Time.deltaTime;
		intDuration = (int)timeDuration;
		//Debug.Log ("Start Time: " + intDuration);

		timerText.text = "Time: " + intDuration.ToString ();
	}

	void Awake () {
		DontDestroyOnLoad (this);
	}
}

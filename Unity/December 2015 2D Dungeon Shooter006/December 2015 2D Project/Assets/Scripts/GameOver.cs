using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public int bestTime;
	public Text timerText;

	public Timer TimerRef;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		SetScore();
	}

	public void SetScore() 
	{
		timerText.text = "Game Time: " + TimerRef.intDuration.ToString();
	}
}

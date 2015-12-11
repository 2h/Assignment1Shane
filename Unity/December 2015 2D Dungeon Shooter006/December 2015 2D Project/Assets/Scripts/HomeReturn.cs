using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HomeReturn : MonoBehaviour {

	//link to PlayerStats to see acorn count
	public PlayerStats PS;
	
	public GameOver GOMenuRef;
	
	public GameObject GOMenu;

	public Timer TimerRef;

	public int captureTime;

	//public Image GameEnd;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player") && PS.countAcorns >= 3)
		{
			Debug.Log ("Complete" + PS.countAcorns);

			captureTime = TimerRef.intDuration;

			Debug.Log("Time " + captureTime);

			GOMenuRef.SetScore();

			GOMenu.SetActive(true);
		}
	}
}

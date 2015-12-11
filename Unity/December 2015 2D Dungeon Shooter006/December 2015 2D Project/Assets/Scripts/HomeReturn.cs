using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HomeReturn : MonoBehaviour {

	//link to PlayerStats to see acorn count
	public PlayerStats PS;

	public Image GameEnd;

	//public GameOver GO;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Player") && PS.countAcorns >= 3)
		{
			Debug.Log ("Complete");

			//GO.SetScore();
			GameEnd.gameObject.SetActive(true);
		}
	}
}

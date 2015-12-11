using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

	public int playerTime;
	public Text timeText;

	public int acornsCollected;
	public Text acornCountText;

	public PlayerStats PS;
	public Timer PT;
	//public HomeReturn HRet;


	//public Button RetMenu;
	
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
			acornsCollected = PS.plyFinishAcorns;
			acornCountText.text = "Acorns: " + acornsCollected.ToString ();
			
			playerTime = PS.plyFinishTime;
			timeText.text = "Time: " + playerTime.ToString ();
	}

	public void LoadMainMenu()
	{
		Application.LoadLevel (0);
	}
}

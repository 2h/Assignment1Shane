﻿//Author:	Hugh Healy
//Date:		7/12/2015
//Time:		13:37
//Script:	Player Stats
//Notes:	Detects Collision. 
//Notes:	In the event that the Player collides with an Item, it is destroyed and Count is increased
//Notes:	In the event that the Player collides with a Foe, the count value is decreased
//Notes:	The Count value is prohibited from going below the value of 0
//Notes:	Functioning

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerStats : MonoBehaviour {
	
	//hold reference to UI Text component - Acorns
	public Text acornCountText;
	public int countAcorns = 0;

	public int plyHealth = 3;
	public int plyMaxHealth = 5;
	public int plyMinHealth = 0;
	public Text plyHealthText;

	public Image gameOverScreen;

	// Use this for initialization
	void Start () 
	{
		acornCountText.text = "Acorns: " + countAcorns.ToString();
		plyHealthText.text = "Health: " + plyHealth.ToString();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnCollisionEnter2D(Collision2D thingWeCollidedWith)
	{
		Debug.Log ("Player Collided with " + thingWeCollidedWith.gameObject.tag);

		if(thingWeCollidedWith.gameObject.CompareTag("Acorn"))
		{
			Destroy(thingWeCollidedWith.gameObject);
			
			countAcorns+=1;
			Debug.Log("Acorns = " + countAcorns);
			SetCountText();
		}

		if (thingWeCollidedWith.gameObject.CompareTag("Fox") || thingWeCollidedWith.gameObject.CompareTag("Hawk")) 
		{

			//Acorns

			countAcorns-=1;
			Debug.Log("Dropped an Item!");

			//Stop minus numbers in collection data
			if(countAcorns < 0)
			{
				countAcorns = 0;
			}

			SetCountText();


			//Health

			//Reduce the players health by 1 following a collision with Foe
			plyHealth-=1;

			SetHealthText();

			if(plyHealth <= plyMinHealth)
			{
				Debug.Log("Game Over!");
				//Destroy(gameObject);
				//gameOverScreen.gameObject.SetActive(true);
				Application.LoadLevel("MainMenu");
			}
		}
	}
	
	void SetCountText()
	{
		//Provides text + a value to the text component of the Count UI component.
		//This is then output on the Game Screen
		acornCountText.text = "Acorns: " + countAcorns.ToString();
	}

	void SetHealthText()
	{
		plyHealthText.text = "Health: " + plyHealth.ToString ();
	}
}

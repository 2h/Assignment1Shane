//Author:	Hugh Healy
//Date:		12/11/2015
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

	public int maxItems = 5;
	public int minItems = 0;
	//hold reference to UI Text component
	public Text countText;
	private int count;


	// Use this for initialization
	void Start () {
		count = 0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void OnCollisionEnter2D(Collision2D thingWeCollidedWith)
	{
		Debug.Log ("Player Collided with " + thingWeCollidedWith.gameObject.tag);

		if(thingWeCollidedWith.gameObject.CompareTag("Item"))
		{
			Destroy(thingWeCollidedWith.gameObject);
			
			count+=1;
			Debug.Log("Count = " + count);
			SetCountText();
		}

		if (thingWeCollidedWith.gameObject.CompareTag("Foe")) 
		{
			count-=1;
			Debug.Log("Dropped an Item!");

			//Stop minus numbers in collection data
			if(count < 0)
			{
				count = 0;
			}

			SetCountText();
		}
	}
	
	void SetCountText()
	{
		//Provides text + a value to the text component of the Count UI component.
		//This is then output on the Game Screen
		countText.text = "Count: " + count.ToString();
	}
}

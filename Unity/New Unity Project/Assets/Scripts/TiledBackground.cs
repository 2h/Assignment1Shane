//Author:	Hugh Healy
//Date:		9/11/2015
//Time:		19:29
//Script:	Camera Controller
//Notes:	Functioning perfectly

using UnityEngine;
using System.Collections;

public class TiledBackground : MonoBehaviour {

	//Take the current tile size (32 * 32) and calculate how many fit within the current screen width and height

	public int textureSize = 32;


	// Use this for initialization
	void Start () {
		//Calcualte how many tiles within the screens resolution
		//Calculate a new width and height
		//Rounded up to avoid gaps at screen edges
		var newWidth = Mathf.Ceil (Screen.width / (textureSize * CameraController.scale));
		var newHeight = Mathf.Ceil (Screen.height / (textureSize * CameraController.scale));

		//Change the scale of the Background Quad based on the new width and height
		transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);

		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
	}
}
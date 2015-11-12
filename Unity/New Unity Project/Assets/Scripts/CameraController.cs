//Author:	Hugh Healy
//Date:		9/11/2015
//Time:		18:00
//Script:	Camera Controller
//Notes:	Functioning

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public static float pixelsToUnits = 1f;
	public static float scale = 1f;

	//Games native resolution
	public Vector2 nativeResolution = new Vector2(240,160);


	// Runs befor the Start method
	void Awake () {

		//On devices of higher Resolution the Camara will be zoomed in closer to maintain the look.

		//Generic type, taking any type, getting reference to the Camera

		var camera = GetComponent<Camera> ();

		//True in 2D mode
		if (camera.orthographic) {

			//scale is equal to the screen height divided by the nativeResolution height(y)
			scale = Screen.height/nativeResolution.y;

			//modify pixels to units to relate to the scale
			pixelsToUnits *= scale;

			//adjust size of Orthographic camera
			//Get half of the Screen Resolution. (Location Zero is the middle of the screen)
			//Multiply half height by the number of pixels per unit to give a new centre position for the camera
			camera.orthographicSize = (Screen.height / 2.0f) / pixelsToUnits;

		}
	}
	
}
//Author:	Hugh Healy
//Date:		11/11/2015
//Time:		18:00
//Script:	Object Rotation Script
//Notes:	Functioning perfectly

using UnityEngine;
using System.Collections;

public class RotateItem : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0, 0, 50) * Time.deltaTime);
	}
}

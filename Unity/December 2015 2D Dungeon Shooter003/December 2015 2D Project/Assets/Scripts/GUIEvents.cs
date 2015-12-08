using UnityEngine;
using System.Collections;

public class GUIEvents : MonoBehaviour {

	public void ReloadLevel()
	{
		Application.LoadLevel (Application.loadedLevelName);
	}

}

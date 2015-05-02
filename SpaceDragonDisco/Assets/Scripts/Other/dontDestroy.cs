using UnityEngine;
using System.Collections;

public class dontDestroy : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
	
		if((Application.loadedLevel == (01))||(Application.loadedLevel == (02)))
		{
			DontDestroyOnLoad(this.gameObject);
		}
		else
		{
			DestroyImmediate(this.gameObject);
		}
	}

}

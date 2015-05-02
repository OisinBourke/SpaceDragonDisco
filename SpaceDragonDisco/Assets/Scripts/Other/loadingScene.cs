using UnityEngine;
using System.Collections;

public class loadingScene : MonoBehaviour {


	float countDown = .1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		countDown -= Time.deltaTime;
		if(countDown <= 0)
		{
			Application.LoadLevel(Application.loadedLevel +1);
		}

	}
}

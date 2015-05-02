using UnityEngine;
using System.Collections;

public class destroyLampfromtheLamp : MonoBehaviour {

	float countDown = 1f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		countDown -= Time.deltaTime;
		if(countDown <= 0f)
		{
			countDown = 1f;
			Destroy(this.gameObject);
		}
	}
}

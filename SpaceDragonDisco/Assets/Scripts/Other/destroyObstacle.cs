using UnityEngine;
using System.Collections;

public class destroyObstacle : MonoBehaviour {
	
	float countDown = 2f;
	
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
			countDown = 2f;
			Destroy(this.gameObject);
		}
	}
}

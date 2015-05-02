using UnityEngine;
using System.Collections;

public class stLampInstantiate : MonoBehaviour {

	public GameObject myObjects;
	public Vector3 myPosition;
	public float countDown = 1f;
		
	void Start () 
	{
		myPosition = transform.position;
	}
	void Update () 
	{
		countDown -= Time.deltaTime;

		if(countDown <= 0f)
		{
			Instantiate((GameObject)myObjects,myPosition,Quaternion.Euler(0,0,0));
			countDown = 1f;
		}

	}
			
			

}

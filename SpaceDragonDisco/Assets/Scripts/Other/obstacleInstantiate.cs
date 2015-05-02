using UnityEngine;
using System.Collections;

public class obstacleInstantiate : MonoBehaviour {

	public GameObject myObstacle;
	public Vector3 myPosition;

	
	void Start () 
	{
		myPosition = transform.position;
	}
	void Update () 
	{
	
		
		if(Input.GetKey(KeyCode.O))
		{
			Instantiate((GameObject)myObstacle,myPosition,Quaternion.Euler(0,0,0));

		}
		
	}
	
	
	
}

using UnityEngine;
using System.Collections;

public class cityBouncyBouncy : MonoBehaviour {

	public Vector3 direction;
//	public Vector3 lrDirection;
//	public Vector3 neutralDirection;

	// Use this for initialization
	void Start () 
	{

//		lrDirection = new Vector3 (5,0,0);
//		lrDirection = new Vector3 (0,0,0);
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += direction * Time.deltaTime;

		if (transform.localPosition.y <= 170|| transform.localPosition.y >= 200)
			 {
				     direction = -direction;
			 }
//		if(Input.GetKey(KeyCode.A))
//		{
//			transform.localPosition += lrDirection;
//		}
//		if(Input.GetKey(KeyCode.A))
//		{
//			transform.localPosition += -lrDirection;
//		}
//		else
//		{
//			transform.localPosition = neutralDirection;
//		}

	}
}

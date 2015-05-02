using UnityEngine;
using System.Collections;

public class oisControl : MonoBehaviour {


	public float mySpeed = 500f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float myForce = Time.deltaTime * mySpeed;

		if(Input.GetKeyDown(KeyCode.W))
		{
			this.rigidbody.AddForce(0,0,mySpeed);
		}


		if(Input.GetKey(KeyCode.A))
		{
			transform.Rotate(0,2,0);
		}
		else if(Input.GetKey(KeyCode.D))
		{
			transform.Rotate(0,-2,0);
		}
		else
		{
			transform.Rotate(0,0,0);
		}

		this.rigidbody.AddForce(0,0,2);
	
	}
}

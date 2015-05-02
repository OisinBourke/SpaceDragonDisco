using UnityEngine;
using System.Collections;

public class streetlampMove : MonoBehaviour {

	public float myAccelerator = -1000f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		float moveSpeed = Time.deltaTime * myAccelerator;


		transform.Translate(Vector3.forward * moveSpeed);
	}
}

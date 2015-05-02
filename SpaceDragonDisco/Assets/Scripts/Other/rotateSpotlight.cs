using UnityEngine;
using System.Collections;

public class rotateSpotlight : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(6.5f,0,0);
	}
}

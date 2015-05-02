using UnityEngine;
using System.Collections;

public class rotateCamera : MonoBehaviour {

    public float rotationAmount;
	void Start () 
    {
	
	}
	
	
	void Update () 
    {
        transform.Rotate(rotationAmount, 0, 0);
	}
}

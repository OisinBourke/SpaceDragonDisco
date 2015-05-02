using UnityEngine;
using System.Collections;

public class changeCameraAngle : MonoBehaviour {

	public GameObject camWayPoint;

	public GameObject UIWayPoint;
	public GameObject UIWayPoint2;
	public Camera UICam;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKey(KeyCode.Alpha1))
		{
			Camera.main.GetComponent<SmoothFollow>().enabled = true;
			UICam.transform.rotation = UIWayPoint2.transform.rotation;
			UICam.transform.position = UIWayPoint2.transform.position;
		}
		if(Input.GetKey(KeyCode.Alpha2))
		{
			Camera.main.GetComponent<SmoothFollow>().enabled = false;
			Camera.main.transform.position = camWayPoint.transform.position;
			Camera.main.transform.rotation = camWayPoint.transform.rotation;
			UICam.transform.rotation = UIWayPoint.transform.rotation;
			UICam.transform.position = UIWayPoint.transform.position;
		}
	
	}
}

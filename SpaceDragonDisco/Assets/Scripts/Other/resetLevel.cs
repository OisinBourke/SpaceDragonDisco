using UnityEngine;
using System.Collections;

public class resetLevel : MonoBehaviour {

//	private bool obManONOFF = true;


	void Update () 
	{
		if(Input.GetKey(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}


		// This is a toggle for resetting the random floating objects if they start behaving too wildly
		//the reactivate won't work because you cant find the tag of a disabled object
		// will fix later.

	
//		if(Input.GetKeyDown(KeyCode.T))
//		{
//			obManONOFF = !obManONOFF;
//			Debug.Log("obManOnOff = " + obManONOFF);
//		}
//
//		if(obManONOFF)
//		{
//			GameObject[] ObMans = GameObject.FindGameObjectsWithTag("ObjectManager");
//			foreach (GameObject ObMan in ObMans)
//			{
//				ObMan.active = false;
//			}
//		}
//		else if (!obManONOFF)
//		{
//			GameObject[] ObMans = GameObject.FindGameObjectsWithTag("ObjectManager");
//			foreach (GameObject ObMan in ObMans)
//			{
//				ObMan.active = true;
//			}
//		}
	}
}

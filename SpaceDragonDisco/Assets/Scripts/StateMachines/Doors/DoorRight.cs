﻿using UnityEngine;
using System.Collections;
//this script goes on the doors, it will initiate the first state
public class DoorRight : MonoBehaviour {

	void Start () 
	{
		Transform player = GameObject.FindWithTag("Player").transform;
		this.gameObject.GetComponent<StateMachine>().SwitchState(new DoorClosed(this.gameObject, player)); 
        //call SwitchState and create a new state for it, passing over the constructor argument
	}
}

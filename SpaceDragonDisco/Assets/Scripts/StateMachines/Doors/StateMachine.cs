﻿using UnityEngine;
using System.Collections;
//this script controls our door statemachine behaviour
public class StateMachine : MonoBehaviour {
    //Hi Paul, I've kept your descriptions for the below methods.
	State currentState; //create a new instance of State called currentState. Our state is stored in here.
	
	void Update () 
	{
		if(currentState != null)
		{
			currentState.Update(); //run the update method from the currentState
		}
	}
	
	public void SwitchState(State newState) //call this when we want to switch state and pass over the newState
	{
		if(currentState != null)
		{
			currentState.Exit(); //run the exit method from the currentState
		}
		
		currentState = newState; //set currentState to newState, which is passed over when we call the SwitchState method
		if(newState != null)
		{
			currentState.Enter();//run the Enter method from the currentState
		}
	}
}

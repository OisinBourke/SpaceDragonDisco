//this script is referenced in the PathFollow function of the SteeringBehavior script
//It's used when using a waypoint system but I don't have one in the space-dragon-disco scene so it's not used.

using UnityEngine;
using System.Collections.Generic;

public class Path : MonoBehaviour {

    //list our waypoints
	List<Vector3> waypoints = new List<Vector3>();
	public int next = 0;
	public bool looped = true;


    //all the functions here are called elsewhere(steerubgbehavior script).
	public void CreatePath()
	{
		for(int i = 0; i < 10; i++)
		{
			waypoints.Add (Random.insideUnitSphere * 150f);
		}
	}
	
	public Vector3 NextWaypoint()
	{
		return waypoints[next];
	}
	
	public bool IsLastCheckpoint()
	{
		return(next == waypoints.Count-1);
	}
	
	public void AdvanceWaypoint()
	{
		if(looped)
		{
			next = (next + 1) % waypoints.Count;
		}
		else
		{
			if(!IsLastCheckpoint())
			{
				next = next + 1;
			}
		}
	}
}

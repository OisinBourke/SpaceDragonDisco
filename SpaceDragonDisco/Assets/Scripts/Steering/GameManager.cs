//This script finds and lists the boids and leader gameobjects, in my case the boids are the "heads" of the dragons and leader is the star thingy

using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	GameObject[] boids;
	GameObject leader;

	void Start () 
	{
		leader = GameObject.Find ("Leader");
		FindBoids();
		GiveBoidsStartState();
	}
	
	void FindBoids()
	{
		boids = GameObject.FindGameObjectsWithTag("Chaser");
	}
	
	void GiveBoidsStartState()
	{
		foreach(GameObject boid in boids)
		{
			boid.GetComponent<StateMachineSteer>().SwitchState (new ChaseState(boid));
		}
		leader.GetComponent<StateMachineSteer>().SwitchState (new PatrolState(leader));
        
	}
}

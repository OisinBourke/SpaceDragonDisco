using UnityEngine;
using System.Collections;

public class obstacleSound : MonoBehaviour {

	public float delayTime = 1f;
	public float countDown;
	bool countDownGO = false;


	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.O))
		{
//			audio.enabled = true;
			audio.PlayDelayed(delayTime);
			countDown -= Time.deltaTime;
			countDownGO = true;
		}
		if(countDown <= 0f)
		{
//			audio.enabled = false;
			audio.Stop();
			countDownGO = false;
			countDown = 3f;
		}
		if(countDownGO)
		{
			countDown -= Time.deltaTime;
		}

	}
}

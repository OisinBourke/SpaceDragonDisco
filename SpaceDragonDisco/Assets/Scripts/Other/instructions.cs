using UnityEngine;
using System.Collections;

public class instructions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.F1))
		{
			UITweener thisTween = this.gameObject.GetComponent<TweenPosition>();
			thisTween.enabled = true;
			UITweener instruct = GameObject.FindGameObjectWithTag("instruct2").GetComponent<TweenPosition>();
			instruct.enabled = true;

		}
	}
}

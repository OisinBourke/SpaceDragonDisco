using UnityEngine;
using System.Collections;

public class textureOffset : MonoBehaviour {

	public float scrollSpeed = 100f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float offset = Time.time * scrollSpeed;
		renderer.material.SetTextureOffset("_MainTex",new Vector2(0,-offset));
	}
}

using UnityEngine;
using System.Collections;

public class explosionForce : MonoBehaviour {

	private float radius = 1000.0F;
	private float power = -1000.0F;
	private float countDown = 3f;
	private float countDown2 = 3f;
	//public Material cubeMat;
	public Material wheelMat;

	bool countdown2Start = false;


	void Start()
	{
		//set the cubes to invisible.

	//	cubeMat.color = new Color(0,0,0,0);
		wheelMat.color = new Color(0,0,0,0);

	}

	void Update() 
	{
	
		Vector3 explosionPos = transform.position;
		Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
		foreach (Collider hit in colliders) 
		{
			if (hit && hit.rigidbody)
				hit.rigidbody.AddExplosionForce(power, explosionPos, radius, 3.0F);
		}

		if (Input.GetKey(KeyCode.X))
		{
			radius = 100f;
			power = 10f;
		//	Debug.Log("radius = "+ radius + " power = " + power);

//			if(GameObject.FindGameObjectWithTag("pressX"))
//			{
//				GameObject pressX = GameObject.FindGameObjectWithTag("pressX");
//				pressX.audio.volume = 1;
//			}

		}
		else if (Input.GetKey(KeyCode.C))
		{
			radius = 10f;
			power = -100f;
		//	Debug.Log("radius = "+ radius + " power = " + power);

			if(GameObject.FindGameObjectWithTag("pressC"))
			{
				GameObject pressC = GameObject.FindGameObjectWithTag("pressC");
				pressC.audio.volume = 1;
			}
		}
		else
		{
			radius = 1000f;
			power = -1000f;
		}
	
	//make car chassis dissappear

		if((Input.GetKey(KeyCode.X))||(Input.GetKey(KeyCode.C)))
		{
			countDown = 3f;
			GameObject.FindGameObjectWithTag("carChassis").renderer.enabled = false;
			//GameObject.FindGameObjectWithTag("carChassis2").renderer.enabled = false;
			//GameObject.FindGameObjectWithTag("engineBlast").renderer.enabled = false;#
			GameObject[] blasts = GameObject.FindGameObjectsWithTag("engineBlast");
			foreach (GameObject blast in blasts)
			{
				blast.renderer.enabled = false;
				if(GameObject.FindGameObjectWithTag("engineAudio"))
				{
					GameObject engineAudio = GameObject.FindGameObjectWithTag("engineAudio");
					engineAudio.audio.volume = 0;
				}

			}

			GameObject.FindGameObjectWithTag("engine").renderer.enabled = false;

			GameObject[] wheels = GameObject.FindGameObjectsWithTag("wheel");
			foreach (GameObject wheel in wheels)
			{
				wheel.renderer.enabled = false;
			}
			GameObject[] cubes  = GameObject.FindGameObjectsWithTag("cube");
			foreach (GameObject cube in cubes)
			{
				cube.renderer.enabled = true;
			}
		//	cubeMat.color = new Color(1,1,1,1);
			wheelMat.color = new Color(1,1,1,1);
		}
		else
		{
			countDown -= Time.deltaTime;
			if(countDown <= 2f)
			{
				GameObject.FindGameObjectWithTag("carChassis").renderer.enabled = true;
			//	cubeMat.color = new Color(0,0,0,0);
				wheelMat.color = new Color(0,0,0,0);

			}
			if(countDown <= 1.75f)
			{
				//GameObject.FindGameObjectWithTag("carChassis2").renderer.enabled = true;
				GameObject.FindGameObjectWithTag("engine").renderer.enabled = true;
				GameObject[] wheels = GameObject.FindGameObjectsWithTag("wheel");
				foreach (GameObject wheel in wheels)
				{
					wheel.renderer.enabled = true;
				}
				GameObject[] cubes  = GameObject.FindGameObjectsWithTag("cube");
				foreach (GameObject cube in cubes)
				{
					cube.renderer.enabled = false;
				}
			}
			if(countDown <= 1f)
			{
				//GameObject.FindGameObjectWithTag("engineBlast").renderer.enabled = true;
				GameObject[] blasts = GameObject.FindGameObjectsWithTag("engineBlast");
				foreach (GameObject blast in blasts)
				{
					blast.renderer.enabled = true;
					if(GameObject.FindGameObjectWithTag("engineAudio"))
					{
						GameObject engineAudio = GameObject.FindGameObjectWithTag("engineAudio");
						engineAudio.audio.volume = 1;
					}
				}
			}
		}

		if(Input.GetKey(KeyCode.A))
		{
			countDown = 2f;
			//GameObject.FindGameObjectWithTag("engineBlast").renderer.enabled = false;
			GameObject[] blasts = GameObject.FindGameObjectsWithTag("engineBlast");
			foreach (GameObject blast in blasts)
			{
				blast.renderer.enabled = false;
				if(GameObject.FindGameObjectWithTag("engineAudio"))
				{
					GameObject engineAudio = GameObject.FindGameObjectWithTag("engineAudio");
					engineAudio.audio.volume = 0;
				}
				if(GameObject.FindGameObjectWithTag("tireSkid"))
				{
					GameObject tireSkid = GameObject.FindGameObjectWithTag("tireSkid");
					tireSkid.audio.volume = 1;
				}
			}

		}
		if(Input.GetKey(KeyCode.D))
		{
			countDown = 2f;
			//GameObject.FindGameObjectWithTag("engineBlast").renderer.enabled = false;
			GameObject[] blasts = GameObject.FindGameObjectsWithTag("engineBlast");
			foreach (GameObject blast in blasts)
			{
				blast.renderer.enabled = false;
				if(GameObject.FindGameObjectWithTag("engineAudio"))
				{
					GameObject engineAudio = GameObject.FindGameObjectWithTag("engineAudio");
					engineAudio.audio.volume = 0;
				}
			}
			if(GameObject.FindGameObjectWithTag("tireSkid"))
			{
				GameObject tireSkid = GameObject.FindGameObjectWithTag("tireSkid");
				tireSkid.audio.volume = 1;
			}
			}


		if((Input.GetKeyUp(KeyCode.D))||(Input.GetKeyUp(KeyCode.A)))
		{
			if(GameObject.FindGameObjectWithTag("tireSkid"))
			{
				GameObject tireSkid = GameObject.FindGameObjectWithTag("tireSkid");
				tireSkid.audio.volume = 0;
			}
		}
		if(Input.GetKeyUp(KeyCode.C))
		{
			if(GameObject.FindGameObjectWithTag("pressC"))
			{
				GameObject pressC = GameObject.FindGameObjectWithTag("pressC");
				pressC.audio.volume = 0;
			}
		}

		//for the backwards audiobits

		if(Input.GetKeyUp(KeyCode.C))
		{
			//put reverse audio volume up here
			if(GameObject.FindGameObjectWithTag("releaseC"))
			{
				GameObject releaseC = GameObject.FindGameObjectWithTag("releaseC");
				releaseC.audio.volume = 1;
				Debug.Log("releaseVol = 1");
			}
			countdown2Start = true;

		}
		if(countDown2 <= 1f)
		{
			Debug.Log("count2 = 1!!");
			//put reverse audio volume down here
			if(GameObject.FindGameObjectWithTag("releaseC"))
			{
				GameObject releaseC = GameObject.FindGameObjectWithTag("releaseC");
				releaseC.audio.volume = 0;
				Debug.Log("releaseVol = 0");

			}
			
			Debug.Log("count2 = 1");
			//put reverse audio volume down here
//			if(GameObject.FindGameObjectWithTag("releaseX"))
//			{
//				GameObject releaseX = GameObject.FindGameObjectWithTag("releaseX");
//				releaseX.audio.volume = 0;
//				//	Debug.Log("releaseXVol = 0");
//			}
//			if(GameObject.FindGameObjectWithTag("pressX"))
//			{
//				GameObject pressX = GameObject.FindGameObjectWithTag("pressX");
//				pressX.audio.volume = 0;
//			}
			countDown2 = 3f;
			countdown2Start = false;
		}
		if(countdown2Start)
	    {
			countDown2 -= Time.deltaTime;
		}



		if(Input.GetKeyUp(KeyCode.X))
		{
			//put reverse audio volume up here
			if(GameObject.FindGameObjectWithTag("releaseX"))
			{
				GameObject releaseX = GameObject.FindGameObjectWithTag("releaseX");
				releaseX.audio.enabled = true;
			//	Debug.Log("releaseXVol = 1");
			}
//			if(GameObject.FindGameObjectWithTag("pressX"))
//			{
//				GameObject pressX = GameObject.FindGameObjectWithTag("pressX");
//				pressX.audio.volume = 0;
//			}
			if(GameObject.FindGameObjectWithTag("pressX"))
			{
				GameObject pressX = GameObject.FindGameObjectWithTag("pressX");
				pressX.audio.enabled = false;
			}
			countdown2Start = true;

			
		}
		if(countDown2 <= 1f)
		{
		}

		//Debug.Log(countDown2);
		//Debug.Log(countdown2Start);



		//messy solution to messy problem. 
		//putting this in the GetKey version above just repeats the sound every frame.
		if(Input.GetKeyDown(KeyCode.X))
		{
			if(GameObject.FindGameObjectWithTag("pressX"))
			{
				GameObject pressX = GameObject.FindGameObjectWithTag("pressX");
				pressX.audio.enabled = true;
			}
			if(GameObject.FindGameObjectWithTag("releaseX"))
			{
				GameObject releaseX = GameObject.FindGameObjectWithTag("releaseX");
				releaseX.audio.enabled = false;
			}
		}








	}


}
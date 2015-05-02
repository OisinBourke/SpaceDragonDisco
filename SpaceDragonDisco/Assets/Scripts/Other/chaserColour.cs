using UnityEngine;
using System.Collections;

public class chaserColour : MonoBehaviour {

    public Material dragonSkin;

	void Start () 
    {
	
	}
	

	void Update () 
    {
	    if(Input.GetKeyDown(KeyCode.Space)) 
        {
            StartCoroutine(ColourChange());

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            StopAllCoroutines();
            dragonSkin.color = Color.white;
        }
    }

    IEnumerator ColourChange() 
    {

        

        yield return new WaitForSeconds(.1f);
        dragonSkin.color = new Color(Random.value, Random.value, Random.value, 1.0f); 
        StartCoroutine(ColourChange());




        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.red;
        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.yellow;
        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.blue;
        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.cyan;
        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.green;
        //yield return new WaitForSeconds(.1f);
        //dragonSkin.color = Color.white;
        //StartCoroutine(ColourChange());
    }
	

}

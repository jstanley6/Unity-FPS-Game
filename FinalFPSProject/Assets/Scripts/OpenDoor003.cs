using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor003 : MonoBehaviour {

    public GameObject textDisplay;
    public float theDistance = PlayerCasting.distanceFromTarget;
    public GameObject theDoor;
    public bool doorOpen = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        theDistance = PlayerCasting.distanceFromTarget;
      
	}

    private void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textDisplay.GetComponent<Text>().text = "Press Button";
        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                StartCoroutine(OpenTheDoor());

            }
        }
    }

    private void OnMouseExit()
    {
        textDisplay.GetComponent<Text>().text = "";
    }

    IEnumerator OpenTheDoor()
    {
        theDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        theDoor.GetComponent<Animator>().enabled = false;
        yield return new WaitForSeconds(10);
        theDoor.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(1);
        theDoor.GetComponent<Animator>().enabled = false;


    }


}

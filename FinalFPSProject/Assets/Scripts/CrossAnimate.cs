using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossAnimate : MonoBehaviour {

    public GameObject upCurs;
    public GameObject rightCurs;
    public GameObject downCurs;
    public GameObject leftCurs;
    public float crossHairDelay = 0.1f;

    // Use this for initialization
    void Start () {
        if (Input.GetButtonDown("Fire1"))
        {
            upCurs.GetComponent<Animator>().enabled = true;
            downCurs.GetComponent<Animator>().enabled = true;
            leftCurs.GetComponent<Animator>().enabled = true;
            rightCurs.GetComponent<Animator>().enabled = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (GlobalAmmoHandgun.loadedAmmo >= 1 || GlobalAmmoSMG.loadedAmmo >= 1)
        {

            if (Input.GetButtonDown("Fire1"))
            {

                upCurs.GetComponent<Animator>().enabled = true;
                downCurs.GetComponent<Animator>().enabled = true;
                leftCurs.GetComponent<Animator>().enabled = true;
                rightCurs.GetComponent<Animator>().enabled = true;
                StartCoroutine(WaitingAnim());
            }
        }
    }

    IEnumerator WaitingAnim()
    {
        yield return new WaitForSeconds(crossHairDelay);
        upCurs.GetComponent<Animator>().enabled = false;
        downCurs.GetComponent<Animator>().enabled = false;
        leftCurs.GetComponent<Animator>().enabled = false;
        rightCurs.GetComponent<Animator>().enabled = false;
       

       
        
    }
}

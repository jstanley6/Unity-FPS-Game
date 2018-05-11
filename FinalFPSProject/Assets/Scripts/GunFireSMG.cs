using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFireSMG : MonoBehaviour {

    public GameObject smg;
    public AudioSource soundSMG;
    public GameObject muzzleFlash;
    public int ammoCount;
    public int firing;
    public GameObject upCurs;
    public GameObject rightCurs;
    public GameObject downCurs;
    public GameObject leftCurs;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ammoCount = GlobalAmmoSMG.loadedAmmo;
        if(Input.GetButtonDown("Fire1"))
        {
            if(ammoCount >= 1)
            {
                if(firing == 0)
                {
                   StartCoroutine(SMGFire());
                }
            }
        }
	}

    IEnumerator SMGFire()
    {
        firing = 1;
        upCurs.GetComponent<Animator>().enabled = true;
        downCurs.GetComponent<Animator>().enabled = true;
        leftCurs.GetComponent<Animator>().enabled = true;
        rightCurs.GetComponent<Animator>().enabled = true;
        GlobalAmmoSMG.loadedAmmo -= 1;
        soundSMG.Play();
        muzzleFlash.SetActive(true);
        smg.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        muzzleFlash.SetActive(false);
        smg.GetComponent<Animator>().enabled = false;
        upCurs.GetComponent<Animator>().enabled = false;
        downCurs.GetComponent<Animator>().enabled = false;
        leftCurs.GetComponent<Animator>().enabled = false;
        rightCurs.GetComponent<Animator>().enabled = false;
        firing = 0; 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

    public GameObject flash;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GlobalAmmoHandgun.loadedAmmo >= 1 || GlobalAmmoSMG.loadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                AudioSource gunSound = GetComponent<AudioSource>();
                gunSound.Play();
                flash.SetActive(true);
                StartCoroutine(MuzzleOff());
                GetComponent<Animation>().Play("GunShot");
                GlobalAmmoHandgun.loadedAmmo -= 1;
                GlobalAmmoSMG.loadedAmmo -= 1;
            }
        }
	}

    IEnumerator MuzzleOff()
    {
        yield return new WaitForSeconds(0.1f);
        flash.SetActive(false);
    }
}

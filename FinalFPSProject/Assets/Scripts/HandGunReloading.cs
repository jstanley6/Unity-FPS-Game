using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunReloading : MonoBehaviour {

    public AudioSource reloadSound;
    public GameObject crossObject;
    public GameObject mechanicsObject;
    public int clipCount;
    public int reserveCount;
    public int reloadAvailable;



	// Use this for initialization
	void Start () {
       

	}
	
	// Update is called once per frame
	void Update () {
        clipCount = GlobalAmmoHandgun.loadedAmmo;
        reserveCount = GlobalAmmoHandgun.currentAmmo;
        if(reserveCount == 0)
        {
            reloadAvailable = 0;

        } else
        {
            reloadAvailable = 10 - clipCount;
        }

        if(Input.GetButtonDown("Reload"))
        {
            if(reloadAvailable >= 1)
            {
                if (reserveCount <= reloadAvailable)
                {
                    GlobalAmmoHandgun.loadedAmmo += reserveCount;
                    GlobalAmmoHandgun.currentAmmo -= reserveCount;
                    ActionReload();
                } else
                {
                    GlobalAmmoHandgun.loadedAmmo += reloadAvailable;
                    GlobalAmmoHandgun.currentAmmo -= reloadAvailable;
                    ActionReload();
                }
            }
            StartCoroutine(EnableScripts());
        }
    }

    IEnumerator EnableScripts()
    {
        yield return new WaitForSeconds(1.1f);
        this.GetComponent<GunFire>().enabled = true;
        crossObject.SetActive(true);
        mechanicsObject.SetActive(true);
    }

    void ActionReload()
    {

        this.GetComponent<GunFire>().enabled = true;
        crossObject.SetActive(false);
        mechanicsObject.SetActive(false);
        reloadSound.Play();
        GetComponent<Animation>().Play("HandgunReload");
    }
}

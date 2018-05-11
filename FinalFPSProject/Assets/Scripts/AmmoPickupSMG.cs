using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoPickupSMG : MonoBehaviour {

    public AudioSource ammoSound;
 

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider col)
    {
            ammoSound.Play();
        
        if (GlobalAmmoSMG.loadedAmmo == 0)
        {
            
            GlobalAmmoSMG.loadedAmmo += 60;
            this.gameObject.SetActive(false);
        }
        else

        {
            GlobalAmmoSMG.currentAmmo += 60;
            this.gameObject.SetActive(false);
        }
    }
}

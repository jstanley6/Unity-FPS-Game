using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

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

            if (GlobalAmmoHandgun.loadedAmmo == 0)
            {
                GlobalAmmoHandgun.loadedAmmo += 10;
                this.gameObject.SetActive(false);
            }
            else

            {
                GlobalAmmoHandgun.currentAmmo += 50;
                this.gameObject.SetActive(false);
            }
        }
}

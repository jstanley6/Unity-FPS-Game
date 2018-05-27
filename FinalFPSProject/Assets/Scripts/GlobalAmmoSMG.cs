using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalAmmoSMG : MonoBehaviour {

    public static int currentAmmo;
    public int internalAmmo;
    public GameObject ammoDisplay;
    public static int loadedAmmo;
    public int internalLoaded;
    public GameObject loadedDisplay;
    

    // Use this for initialization
    void Start() {
       
    }
	
	// Update is called once per frame
	void Update () {
        internalAmmo = currentAmmo;
        internalLoaded = loadedAmmo;
        ammoDisplay.GetComponent<Text>().text = "" + internalAmmo;
        loadedDisplay.GetComponent<Text>().text = "" + loadedAmmo;
    }
}

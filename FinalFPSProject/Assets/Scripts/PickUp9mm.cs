using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp9mm : MonoBehaviour {

    public float theDistance = PlayerCasting.distanceFromTarget;
    public GameObject textDisplay;
    public GameObject fakeGun;
    public GameObject realGun;
    public GameObject ammoDisplay;
    public AudioSource pickUpNineAudio;
    public GameObject objectiveComplete;
    public GameObject thePlayer;
    private WeaponManager weaponManager;
    public GameObject weaponHandgunDisplay;
    public GameObject weaponSMGDisplay;

	// Use this for initialization
	void Start () {
        weaponManager = thePlayer.GetComponent<WeaponManager>();
       
	}
	
	// Update is called once per frame
	void Update () {
        theDistance = PlayerCasting.distanceFromTarget;
      
	}

    private void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textDisplay.GetComponent<Text>().text = "Take 9mm Pistol";

        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                 TakeNineMil();
                objectiveComplete.SetActive(true);
                ObjectivesComplete.finishedObjectives += 1;
            }
        }
    }

    private void OnMouseExit()
    {
        if (theDistance <= 2)
        {
            textDisplay.GetComponent<Text>().text = "";

        }
    }

  

    void TakeNineMil()
    {
        //weaponHandgunDisplay.SetActive(true);
        //weaponSMGDisplay.SetActive(false);
        pickUpNineAudio.Play();
        transform.position = new Vector3(0, -1000, 0);
        fakeGun.SetActive(false);
        realGun.SetActive(true);
        ammoDisplay.SetActive(true);
        weaponManager.addWeapon(realGun);
        Debug.Log(weaponManager.name);
        Debug.Log(weaponManager.weapons.Count);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpSMG : MonoBehaviour {

    public float theDistance = PlayerCasting.distanceFromTarget;
    public GameObject textDisplay;
    public GameObject fakeGun;
    public GameObject realGun;
    public GameObject ammoDisplay;
    public AudioSource pickUpNineAudio;
    public GameObject objectiveComplete;
    public GameObject mechanics;
    public GameObject player;
    private WeaponManager weaponManager;
    //public GameObject weaponHandgunDisplay;
    //public GameObject weaponSMGDisplay;

    // Use this for initialization
    void Start () {
        weaponManager = player.GetComponent<WeaponManager>();
        
       
       
    }
	
	// Update is called once per frame
	void Update () {
        theDistance = PlayerCasting.distanceFromTarget;
      
	}

    private void OnMouseOver()
    {
        if(theDistance <= 2)
        {
            textDisplay.GetComponent<Text>().text = "Take SMG";

        }
        if (Input.GetButtonDown("Action"))
        {
            if (theDistance <= 2)
            {
                 TakeSMG();
                mechanics.SetActive(true);
                objectiveComplete.SetActive(true);
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

    void TakeSMG()
    {
        //weaponSMGDisplay.SetActive(true);
        //weaponHandgunDisplay.SetActive(false);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponManager : MonoBehaviour {

    public ArrayList weapons;
    public static GameObject activeWeapon;
    public float lastTime;
    //public GameObject loadedDisplay;
    //public GameObject ammoDisplay;
    //public GameObject smgammoLabel;
    //public GameObject handGunammoLabel;
  
    

  
     


    // Use this for initialization
    void Start () {
        weapons = new ArrayList();
        lastTime = Time.time;
       
	}

    // Update is called once per frame
    void Update()
    {
       
        if (activeWeapon)
        {
            activeWeapon.SetActive(true);

            for (int i = 0; i < weapons.Count; i++)
            {
                if (!weapons[i].Equals(activeWeapon))
                {
                    ((GameObject)weapons[i]).gameObject.SetActive(false);


                }
            }

        }
        SwitchWeaponsScroll();
    }

    void SwitchWeaponsScroll() //GameObject ammoDisplay, GameObject handGunAmmoLabel, GameObject smgAmmoLabel
    {
       int  smgCurrentAmmo = GlobalAmmoSMG.currentAmmo;
       int smgLoadedAmmo = GlobalAmmoSMG.loadedAmmo;
       int handGunCurremtAmmo = GlobalAmmoHandgun.currentAmmo;
       int handGunloadedAmmo = GlobalAmmoHandgun.loadedAmmo;

        if (Input.GetAxis("Mouse ScrollWheel") > 0f && Time.time - lastTime > 1)
        {
            lastTime = Time.time;

            for (int i = 0; i < weapons.Count; i++)
            {
                if (!weapons[i].Equals(activeWeapon))
                {

                  
                        //smgAmmoLabel.SetActive(false);
                        //handGunAmmoLabel.SetActive(true);
                        //ammoDisplay.GetComponent<Text>().text = "" + handGunCurremtAmmo;
                        //loadedDisplay.GetComponent<Text>().text = "" + handGunloadedAmmo;

                        Debug.Log("inside if statement");
                        ((GameObject)weapons[i]).gameObject.SetActive(true);
                        activeWeapon.SetActive(false);
                        Debug.Log(activeWeapon.name);
                        activeWeapon = ((GameObject)weapons[i]).gameObject;
                        Debug.Log(activeWeapon.name);
                        break;
                    
                        //smgAmmoLabel.SetActive(true);
                        //handGunAmmoLabel.SetActive(false);
                        //ammoDisplay.GetComponent<Text>().text = "" + smgCurrentAmmo;
                        //loadedDisplay.GetComponent<Text>().text = "" + smgLoadedAmmo;

                }
            }

        }
    }

    public void addWeapon(GameObject weapon)
    {
        activeWeapon = weapon;
        if(!weapons.Contains(weapon))
        {
            weapons.Add(weapon);
        }
        for (int i = 0; i < weapons.Count; i++)
        {
            if (!weapons[i].Equals(weapon))
            {
                ((GameObject)weapons[i]).gameObject.SetActive(false);
               

            }
        }
    }
}
 
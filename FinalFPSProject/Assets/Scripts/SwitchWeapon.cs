using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapon : MonoBehaviour {

    public int currentWeapon;
    public GameObject activeWeapon;
    public GameObject gun, smg;// list of weapons
    public bool weaponIsSwitching;
    void Start()
    {
        weaponIsSwitching = true;
    }
    void Update()
    {
        float w = Input.GetAxis("Mouse ScrollWheel");
        if (w > 0f)// if scrollwheel has moved up
        {
            currentWeapon = currentWeapon + 1;
            weaponIsSwitching = true; // Setting the bool true here and setting it false after the weapon has changed prevents instantiating more than one instance of the same object.
        }
        else if (w < 0f)// if scrollwheel haas moved down
        {
            currentWeapon = currentWeapon - 1;
            weaponIsSwitching = true; // Setting the bool true here and setting it false after the weapon has changed prevents instantiating more than one instance of the same object.
        }
        if (weaponIsSwitching == true)
        {
            // This switch does the job of actually changing the weapon.
            // Each case would represent a different weapon.
            switch (currentWeapon)
            {
                // When adding a case just be sure to change the prefab (gun, rifle, shotgun) to match whatever weapon you are adding, and increasing the case number by 1 for each case.
                case 0: // Instantiates a weapon named gun

                    Destroy(activeWeapon); // Destroys the current weapon in the scene, ensuring that two weapons are not in the scene at the same time.
                    activeWeapon = Instantiate(gun, new Vector3(activeWeapon.transform.position.x, activeWeapon.transform.position.y, activeWeapon.transform.position.z), Quaternion.identity) as GameObject;
                    weaponIsSwitching = false;
                    break;
                case 1: // Instantiates a weapon named rifle

                    Destroy(activeWeapon); // Destroys the current weapon in the scene, ensuring that two weapons are not in the scene at the same time.
                    activeWeapon = Instantiate(gun, new Vector3(activeWeapon.transform.position.x, activeWeapon.transform.position.y, activeWeapon.transform.position.z), Quaternion.identity) as GameObject;
                    weaponIsSwitching = false;
                    break;
                case 2: // Instantiates a weapon named shotgun

                    Destroy(activeWeapon); // Destroys the current weapon in the scene, ensuring that two weapons are not in the scene at the same time.
                    activeWeapon = Instantiate(smg, new Vector3(activeWeapon.transform.position.x, activeWeapon.transform.position.y, activeWeapon.transform.position.z), Quaternion.identity) as GameObject;
                    weaponIsSwitching = false;
                    break;
            }
        }
        // The following ensures the weapon int never exceeds your amount of weapons.
        if (currentWeapon > 2)// Make sure the number here always mathces the amount of cases in the switch above.
        {
            currentWeapon = 0; // Leave this number the same
        }
        if (currentWeapon < 0) // Leave this number the same
        {
            currentWeapon = 2;// Make sure the number here always mathces the amount of cases in the switch above.
        }
    }
}

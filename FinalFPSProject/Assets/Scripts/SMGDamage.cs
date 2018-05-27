using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SMGDamage : MonoBehaviour {

    public int damageAmount;
    public float targetDistance;
    public float allowedRange = 15f;
    private RaycastHit shot;

    // Use this for initialization
    void Start () {
        damageAmount = 10;
    }
	
	// Update is called once per frame
    
	void Update () {

        if (GlobalAmmoSMG.loadedAmmo >= 1 || GlobalAmmoHandgun.loadedAmmo >= 1) {
            if (Input.GetButtonDown("Fire1"))
            {
                if (Physics.Raycast(transform.position, transform.forward, out shot))
                {
                    targetDistance = shot.distance;
                    if (targetDistance < allowedRange)
                    {
                        shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                    }
                }
            }
        }
        }
}

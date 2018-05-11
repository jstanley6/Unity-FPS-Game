using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandGunDamage : MonoBehaviour {

    public int damageAmount;
    public float targetDistance;
    public float allowedRange = 15f;
    private RaycastHit shot;
    public RaycastHit hit;
    public GameObject theBullet;
    public GameObject theBlood;
    public GameObject objectiveComplete;
    private bool headShot = false;

    

    // Use this for initialization
    void Start () {
        damageAmount = 5;

	}
	
	// Update is called once per frame
	void Update () {
        if (GlobalAmmoHandgun.loadedAmmo >= 1)
        {
            if (Input.GetButtonDown("Fire1"))
            {

                if (Physics.Raycast(transform.position, transform.forward, out shot))
                {
                    targetDistance = shot.distance;
                    if (targetDistance < allowedRange)
                    {
                        
                        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                        {
                            if (hit.transform.tag == "Zombie")
                            {
                                Instantiate(theBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                                GlobalScore.currentScore += 25;
                                if(hit.collider.tag == "ZombieHead")
                                {
                                    GlobalScore.currentScore -= 25;
                                }
                            }

                            if (hit.collider.tag == "ZombieHead")
                            {
                                damageAmount = 10;
                                Instantiate(theBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));
                                objectiveComplete.SetActive(true);
                                if (!headShot)
                                {
                                    ObjectivesComplete.finishedObjectives += 1;
                                    headShot = true;
                                }
                                GlobalScore.currentScore += 100;
                            }

                        }
                        else
                        {
                            Instantiate(theBullet, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));

                        }
                        damageAmount = 5;
                        shot.transform.SendMessage("DeductPoints", damageAmount, SendMessageOptions.DontRequireReceiver);
                        //damageAmount = 5;

                    }
                    
                }
            }
        }
	}
}

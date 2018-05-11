using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFollow : MonoBehaviour {

    public GameObject thePlayer;
    public float targetDistance;
    public float allowedRange = 10;
    public GameObject theEnemy;
    public float enemySpeed;
    public int attackTrigger;
    public RaycastHit shot;
    public int isAttacking;
    public GameObject redScreen;
    public AudioSource hurt01;
    public AudioSource hurt02;
    public AudioSource hurt03;
    public int painSound;

    private void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out shot))
        {
            targetDistance = shot.distance;
            if(targetDistance < allowedRange)
            {
                enemySpeed = 0.01f;
                if(attackTrigger == 0)
                {
                    theEnemy.GetComponent<Animation>().Play("Walking");
                    transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, Time.deltaTime);
                }
            }
        } else
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("Idle");
        }
        if (attackTrigger == 1)
        {
            if (isAttacking == 0)
            {
                StartCoroutine(EnemyDamage());
            } 
            theEnemy.GetComponent<Animation>().Play("Attacking");
            enemySpeed = 0;
        }
    }

    private void OnTriggerEnter()
    {
        attackTrigger = 1;

    }

    private void OnTriggerExit()
    {
        attackTrigger = 0;
    }

    IEnumerator EnemyDamage()
    {
        isAttacking = 1;
        painSound = Random.Range(1, 4);
        yield return new WaitForSeconds(0.9f);
        redScreen.SetActive(true);
        GlobalHealth.playerHealth -= 2;
        if (painSound == 1)
        {
            hurt01.Play();
        }
       if (painSound == 2)
        {
            hurt02.Play();
        }
       if (painSound == 3)
        { 
           hurt03.Play();
        }
        yield return new WaitForSeconds(0.05f);
        redScreen.SetActive(false);
        yield return new WaitForSeconds(1);
        isAttacking = 0;
      }

}

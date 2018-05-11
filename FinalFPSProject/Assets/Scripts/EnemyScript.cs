using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

    public int enemyHealth = 30;
    public GameObject theZombie;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyHealth <= 0)
        {
            this.GetComponent<ZombieFollow>().enabled = false;
            theZombie.GetComponent<Animation>().Play("Dying");
            StartCoroutine(EndZombie());
          //  Destroy(gameObject);
        }
	}

    IEnumerator EndZombie()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }

    void DeductPoints(int damageAmount)
    {
        enemyHealth -= damageAmount;

    }
}

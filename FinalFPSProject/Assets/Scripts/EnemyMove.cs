using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {

    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed;
    public int moveTrigger;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (moveTrigger == 1)
        {
            enemySpeed = 0.02f;
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
        }
    }
}

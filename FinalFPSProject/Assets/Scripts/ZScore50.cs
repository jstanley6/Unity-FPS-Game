using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore50 : MonoBehaviour {

    public GameObject objectiveComplete;
    public bool target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DeductPoints(int damageAmount)
    {
        GlobalScore.currentScore += 50;
        objectiveComplete.SetActive(true);
        if (!target)
        {
            ObjectivesComplete.finishedObjectives += 1;
            target = true;
        }
    }
}

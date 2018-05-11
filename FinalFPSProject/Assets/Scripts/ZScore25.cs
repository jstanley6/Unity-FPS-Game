using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore25 : MonoBehaviour {

    public GameObject objectiveComplete;
    public bool target = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void DeductPoints(int damageAmount)
    {
        GlobalScore.currentScore += 25;
        objectiveComplete.SetActive(true);
        if(!target)
        {
            ObjectivesComplete.finishedObjectives += 1;
            target = true;
        }
        
    }
}

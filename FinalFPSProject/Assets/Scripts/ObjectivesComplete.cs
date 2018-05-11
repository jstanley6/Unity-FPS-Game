using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class ObjectivesComplete : MonoBehaviour {

    public GameObject objectiveComplete;
    public static int finishedObjectives;
    public int finishObj;
    public GameObject levelCompleted;
    public GameObject thePlayer;
    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        finishObj = finishedObjectives;
        StartCoroutine(ObjectivesDone());

        
    }
    
    IEnumerator ObjectivesDone()
    {
        
        if (finishedObjectives == 4)
        {
            levelCompleted.SetActive(true);
            thePlayer.GetComponent<FirstPersonController>().enabled = false;
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(1);
        }
    }
}

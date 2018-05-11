using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour {

    public GameObject thePlayer;
    public bool paused = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Cancel"))
        {
            if(paused == false)
            {
                Time.timeScale = 0;
                paused = true;
                thePlayer.GetComponent<FirstPersonController>().enabled = false;
                Cursor.visible = true;
            }

            else
            {
                thePlayer.GetComponent<FirstPersonController>().enabled = true;
                paused = false;
                Cursor.visible = false;
                Time.timeScale = 1;
            }
        }
	}
}

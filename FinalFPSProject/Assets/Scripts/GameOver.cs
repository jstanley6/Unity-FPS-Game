using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        StartCoroutine(StopGame());
    }

    IEnumerator StopGame()
    {
        //Cursor.visible = true;
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(3);
    }
}

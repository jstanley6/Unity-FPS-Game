using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CredToMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(MainMenu());
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator MainMenu()
    {
        yield return new WaitForSeconds(11);
        SceneManager.LoadScene(3);
    }
}

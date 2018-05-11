using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

    public static int currentScore;
    public int internalScore;
    public GameObject scoreText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        internalScore = currentScore;
        scoreText.GetComponent<Text>().text = "" + internalScore;

	}
}

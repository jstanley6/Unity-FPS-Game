using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour {

    public static float distanceFromTarget;
    public float toTarget;
    private RaycastHit hit;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

         if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            toTarget = hit.distance;
            distanceFromTarget = toTarget;
        }

    }
}


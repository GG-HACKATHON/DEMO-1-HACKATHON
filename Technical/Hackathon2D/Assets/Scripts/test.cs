using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject player;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        Vector3 screenPoint = Input.mousePosition;
        screenPoint.z = 10.0f; //distance of the plane from the camera
        Debug.Log(Camera.main.ScreenToWorldPoint(screenPoint));
    }

    
}

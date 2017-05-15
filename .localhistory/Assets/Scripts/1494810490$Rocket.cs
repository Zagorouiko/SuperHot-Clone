using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Rocket : MonoBehaviour
{

    private Rigidbody r;
    private GameObject camera;

	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody>();
	    camera = GameObject.Find("Camera (head)");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
	}
}

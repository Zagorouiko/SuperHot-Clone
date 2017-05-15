using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Rocket : MonoBehaviour
{

    private Rigidbody r;
    private GameObject camera;

    private bool closeToPlayer = false;
	// Use this for initialization
	void Start () {
		r = GetComponent<Rigidbody>();
	    camera = Camera.main.gameObject;
	    r.velocity = (camera.transform.position - transform.position).normalized * Random.Range(20f, 30f);
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
	    Vector3 velocity = r.velocity;
	    Vector3 currDist = (camera.transform.position - transform.position);

	    if (currDist.magnitude < 0.5f)
	    {
	        closeToPlayer = true;
	    }

	    if (!closeToPlayer)
	    {
	        r.velocity = (camera.transform.position - transform.position).normalized * velocity.magnitude;
	        transform.rotation = Quaternion.LookRotation(transform.position + velocity);
        }
        
	}
}

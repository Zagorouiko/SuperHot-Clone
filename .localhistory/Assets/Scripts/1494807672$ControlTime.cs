using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTime : MonoBehaviour
{
    public float CapVelocity = .1f;

    public SteamVR_TrackedController headset;
    public SteamVR_TrackedController left;
    public SteamVR_TrackedController right;

    private Vector3 prevHeadset;
    private Vector3 prevLeft;
    private Vector3 prevRight;

    // Use this for initialization
    void Start () {
		SetPrevState();
	}
	
	// Update is called once per frame
	void Update ()
	{
	    Vector3 headVel = headset.transform.position - prevHeadset;
	    Vector3 leftVel = left.transform.position - prevLeft;
	    Vector3 rightVel = right.transform.position - prevRight;

	    float totalVel = headVel.magnitude + leftVel.magnitude + rightVel.magnitude;

        Time.timeScale = 1f;

	    SetPrevState();
	}

    void SetPrevState()
    {
        prevHeadset = headset.transform.position;
        prevLeft = left.transform.position;
        prevRight = right.transform.position;
    }
}

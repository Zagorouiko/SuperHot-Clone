using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTime : MonoBehaviour
{

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
	    SetPrevState();
	}

    void SetPrevState()
    {
        prevHeadset = headset.transform.position;
        prevLeft = left.transform.position;
        prevRight = right.transform.position;
    }
}

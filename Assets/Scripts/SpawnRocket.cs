using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRocket : MonoBehaviour
{

    public GameObject rocketPrefab;

	// Use this for initialization
	IEnumerator Start () {
	    while (true)
	    {
	        Vector3 pos = new Vector3(Random.Range(-10f, 10f), Random.Range(2f, 8f), Random.Range(-10f, 10f));
	        Instantiate(rocketPrefab, pos, Quaternion.identity);
	        yield return new WaitForSeconds(2f);
	    }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

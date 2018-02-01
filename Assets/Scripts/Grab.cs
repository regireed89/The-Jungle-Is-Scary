using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {

    Transform t;

	// Use this for initialization
	void Start () {
        t = FindObjectOfType<Enemy_Behaviour>().transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.gameObject.transform.SetParent(gameObject.transform);
        }
    }
}

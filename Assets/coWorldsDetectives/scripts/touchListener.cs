﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class touchListener : MonoBehaviour {

    public bool activated = false;
    public bool enter = false;
    public bool leave = false;
    private Collider box;

	// Use this for initialization
	void Start () {
        box = GetComponent<Collider>();
        box.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        //10 = playerHand
        //Debug.Log("Enter layer " + other.gameObject.layer);
        if(other.gameObject.layer == 10)
        {
            enter = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        //10 = playerHand
        //Debug.Log("Leave layer " + other.gameObject.layer);
        if (other.gameObject.layer == 10)
        {
            activated = true;
            leave = true;
        }
        
    }

}

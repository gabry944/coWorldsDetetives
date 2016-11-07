﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class touchListener : MonoBehaviour {

    public bool activated = false;

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
        if(other.gameObject.layer == 10)
        {
            activated = true;
        }
    }
}
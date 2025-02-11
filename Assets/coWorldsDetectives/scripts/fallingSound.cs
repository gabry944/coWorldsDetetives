﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class fallingSound : MonoBehaviour {

    private AudioSource sound;
    private Rigidbody rb;
    public bool landed;
    private NewtonVR.NVRInteractableItem nvrItem;
    public bool held;
    public float waitTime = 0.1f;
    public float currTime = 0;

    // Use this for initialization
    void Start ()
    {
        sound = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        nvrItem = GetComponent<NewtonVR.NVRInteractableItem>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (rb.useGravity)
        {
            currTime += Time.deltaTime;
        }

        //if the keystone hasn't landed but uses gravity and has low speed
        if (!landed && rb.useGravity && rb.velocity.magnitude < 0.1 && currTime > waitTime)
        {
            landed = true;
            sound.Play();
        }

        if(nvrItem != null && nvrItem.AttachedHand != null)
        {
            held = true;
        }

        if(landed && held && nvrItem.AttachedHand == null)
        {
            landed = false;
            held = false;
        }
    }
}

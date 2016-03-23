﻿using UnityEngine;
using System.Collections;

public class MoveExtraMissile : MonoBehaviour {

    public float speed = 5;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Extra Missile moves down towards player  
        transform.position += (-transform.right) * Time.deltaTime * speed;

    }
}

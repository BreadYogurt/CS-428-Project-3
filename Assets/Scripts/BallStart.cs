﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallStart : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        gameObject.transform.Rotate(Random.Range(-30, 30), Random.Range(-30, 30), 0, Space.Self);
        rb.velocity = new Vector3(0, 0, 10);
        Debug.Log("Moving at " + rb.velocity.magnitude);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

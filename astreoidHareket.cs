﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astreoidHareket : MonoBehaviour
{
    Rigidbody rb;
    public int hiz;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * hiz;
    }
}

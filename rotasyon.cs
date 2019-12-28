using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotasyon : MonoBehaviour
{
    Rigidbody rb;
    public float hiz;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere*hiz; //açısal dönme saglamaya yarar
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    Rigidbody rb;

    float horizontal = 0;
    float vertical = 0;
    float atesZamani = 0;

    Vector3 vec;

    public GameObject kursun;
    public GameObject cikisyeri;

    public AudioSource atesclip;
    
    public float playerHiz = 0;
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public float egim;
    public float atesGecenSure;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>atesZamani) //mouse a tiklandiginda 
        {
            atesZamani = Time.time + atesGecenSure;
            Instantiate(kursun,cikisyeri.transform.position,Quaternion.identity);
            atesclip.Play();

        }
    }

    private void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        vec = new Vector3(horizontal, 0, vertical);
        rb.velocity = vec * playerHiz;

        rb.position = new Vector3(Mathf.Clamp(rb.position.x,minX,maxX),0,Mathf.Clamp(rb.position.z,minZ,maxZ));

        rb.rotation = Quaternion.Euler(0,0,rb.position.x*-egim);
    }
}

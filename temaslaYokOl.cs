using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temaslaYokOl : MonoBehaviour
{
    public GameObject patlama;
    public GameObject playerPatlama;

   

    GameObject OyunKontrol;
    oyunControl kontrol;
    private void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<oyunControl>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag!="kursunsilici")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            Instantiate(patlama,transform.position,Quaternion.identity);
            kontrol.ScoreArttir(10);
            
            
           
        }
        if (other.tag=="Player")
        {
            Instantiate(playerPatlama,other.transform.position,other.transform.rotation);
            
            
        }

       
    }

















}


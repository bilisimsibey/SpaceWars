using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class oyunControl : MonoBehaviour
{
    public GameObject astreoid;

    public Vector3 randomPos;

    public float baslangicBekleme;
    public float olusturmaBekleme;
    public float donguBekleme;

    

    int score;
    public Text scoreTxt;
    private void Start()
    {
        score = 0;
        scoreTxt.text = "Score: "+score;
       
        StartCoroutine(Olustur());
    }
    IEnumerator Olustur()
    {
        yield return new WaitForSeconds(baslangicBekleme);

        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-randomPos.x, randomPos.x), 0, randomPos.z);
                Instantiate(astreoid, vec, Quaternion.identity);
                yield return new WaitForSeconds(olusturmaBekleme);
            }
            yield return new WaitForSeconds(donguBekleme);

            
        }

    }

    public void ScoreArttir(int gelenScore)
    {
        score += gelenScore;
       
        scoreTxt.text = "Score: " + score;

    }


   
   
}

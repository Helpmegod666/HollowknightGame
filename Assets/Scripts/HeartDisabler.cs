using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDisabler : MonoBehaviour
{
    public Hp_scipt hp;
    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;

    void Update()
    {
        if (hp.Hpremaining == 3)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(true);
        }

        if (hp.Hpremaining == 2)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(true);
            heart3.gameObject.SetActive(false);
        }

        if (hp.Hpremaining == 1)
        {
            heart1.gameObject.SetActive(true);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }

        if (hp.Hpremaining == 0)
        {
            heart1.gameObject.SetActive(false);
            heart2.gameObject.SetActive(false);
            heart3.gameObject.SetActive(false);
        }
    }
}

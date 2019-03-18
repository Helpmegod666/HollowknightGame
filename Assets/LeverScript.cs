using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    bool inside;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartSpawn();
        }
    }
    void StartSpawn()
    {
        Invoke("Spawn1", 1);
        Invoke("Spawn2", 3);
        Invoke("Spawn3", 5);
        Invoke("Spawn4", 7);

    }
    void Spawn1()
    {
        spawn1.SetActive(true);
    }
    void Spawn2()
    {
        spawn2.SetActive(true);
    }
    void Spawn3()
    {
        spawn3.SetActive(true);
    }
    void Spawn4()
    {
        spawn4.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    SpriteRenderer selfSprite;
    bool inside;
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;

    private void Start()
    {
        selfSprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            StartSpawn();
            selfSprite.color = new Color(255, 255, 0);
        }
    }
    void StartSpawn()
    {
        Invoke("Spawn1", 1);
        Invoke("Spawn2", 3);
        Invoke("Spawn3", 5);

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
}

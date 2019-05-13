using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPostion : MonoBehaviour
{
    public AudioSource effect;
    GameObject player;
    Hp_scipt Hp;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Hp = player.GetComponent<Hp_scipt>();
    }


    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.tag == "Player")
    //    {
    //        Hp.PotionsRemaining = 1;
    //        Destroy(gameObject);
    //    }
    //}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            effect.Play();
            Hp.PotionsRemaining = 1;
            Destroy(gameObject);
        }
    }
}

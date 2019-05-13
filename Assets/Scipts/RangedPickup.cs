using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedPickup : MonoBehaviour
{
    BoxCollider2D box;
    public AudioSource effect;
    public GameObject player;
    SpriteRenderer selfSprite;
    public GiveAmmo ammo;
    public int ammoToGet = 5;

    private void Update()
    {
        selfSprite = GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
        ammo = player.GetComponent<GiveAmmo>();
        box = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
     
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            effect.Play();
            selfSprite.enabled = false;
            ammo.Giveammo();
            box.isTrigger = true;
            Destroy(gameObject, 0.2f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedPickup : MonoBehaviour
{
    SpriteRenderer selfSprite;
    public RangedAttacksScript weapon;
    public int ammoToGet = 5;
    private void Start()
    {
        selfSprite = GetComponent<SpriteRenderer>();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            selfSprite.enabled = false;
            weapon.ammo += ammoToGet;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedPickup : MonoBehaviour
{
    SpriteRenderer selfSprite;
    public GameObject normalAttack;
    public GameObject rangedAttack;
    private void Start()
    {
        selfSprite = GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            selfSprite.enabled = false;
            normalAttack.SetActive(false);
            rangedAttack.SetActive(true);
        }
    }
}

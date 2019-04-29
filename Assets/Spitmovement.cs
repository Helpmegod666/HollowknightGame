using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitmovement : MonoBehaviour
{
    private Vector2 Direction;

    PlayerMovement player;
    Rigidbody2D rb;
    Hp_scipt hp;

    public float spitspeed = 15;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
        hp = player.GetComponent<Hp_scipt>();
        Direction = (player.transform.position - transform.position).normalized * spitspeed;
        rb.velocity = new Vector2(Direction.x, Direction.y);
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hp.Hpremaining = hp.Hpremaining - 1;
            Destroy(gameObject);
        }
    }
}

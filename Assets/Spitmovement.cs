using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitmovement : MonoBehaviour
{
    private Vector2 Direction;

    private float timer = 0;

    public GameObject spit;
    PlayerMovement player;
    Rigidbody2D rb;
    Hp_scipt hp;

    public float spitspeed = 15;
    public float ricochetspitspeed = 10;

    private void Start()
    {
        player = GameObject.FindObjectOfType<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
        hp = player.GetComponent<Hp_scipt>();
        Direction = (player.transform.position - transform.position).normalized * spitspeed;
        rb.velocity = new Vector2(Direction.x, Direction.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            hp.Hpremaining = hp.Hpremaining - 1;
            Instantiate(spit, transform.position, spit.transform.rotation);
            Destroy(gameObject, 0.05f);
        }

        if (collision.tag == "Ground")
        {
            Instantiate(spit, transform.position, spit.transform.rotation);
            Destroy(gameObject, 0.05f);
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 3)
        {
            Destroy(gameObject);
        }
    }

}

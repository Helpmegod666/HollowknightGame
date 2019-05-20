using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 1.5f;
    public Transform Player;
    public EnemySense Area;
    public EnemyHealth Health;
    Rigidbody2D rbody;
    public float fallspeed = 10f;

    private void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
        }
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Area.Area == true)
        {
            Vector3 displacement = Player.position - transform.position;
            displacement = displacement.normalized;
            if (Vector2.Distance(Player.position, transform.position) > 1.0f)
            {
                transform.position += (displacement * speed * Time.deltaTime);
            }
        }
        else
        {

        }
        if (Health.Health <= 0)
        {
            Death();
            
        }
    }
    void Death()
    {
        rbody.velocity = Vector2.zero;
        transform.Translate(Vector3.down * Time.deltaTime * fallspeed, Space.World);
    }
}
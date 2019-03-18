using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroundHealth : MonoBehaviour
{
    public int Health = 3;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PlayerWepon")
        {
            Health -= 1;
        }
    }

    private void Update()
    {
        if (Health == 0)
        {
            Destroy(gameObject, 5);
        }
    }
}

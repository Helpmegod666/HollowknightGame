using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    public int Health = 1;

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

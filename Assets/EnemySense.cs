using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySense : MonoBehaviour
{
    public bool Area = false;
    public EnemyHealth Health;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Area = true;
        }
    }

    void Update()
    {
        if (Health.Health == 0)
        {
            Area = false;
        }
    }
}

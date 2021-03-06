﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drop_test_enemy : MonoBehaviour
{
    private int randdrop;
    public GameObject potiondrop;
    public GameObject ammoDrop;
    private EnemyHealth EGH;
    private float randtimer = 0;
    private int randcharge = 1;
    
    private int potiondrops = 1;
    private float potiontimer = 0;
    private float ammoTimer = 0;
    private int ammoDrops = 1;

    // Start is called before the first frame update
    void Start()
    {
        EGH = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
       if (EGH.Health <= 0)
       {
            dropchance();
            if (randdrop == 1)
            {
                potiondropping();
            }
            if(randdrop > 5)
            {
                AmmoDropping();
            }


       }

        randchargesreset();
    }

    private void dropchance()
    {
        if (randcharge == 1)
        {
            randdrop = Random.Range(1, 10);
            randcharge = 0;
        }
    }

    private void randchargesreset()
    {
        if (randcharge == 0 && randtimer == 0)
        {
            randtimer += Time.deltaTime;
            if (randtimer == 2)
            {
                randcharge = 1;
                randtimer = 0;
            }
        }
    }

    private void potiondropping()
    {
        if (potiontimer == 0 && potiondrops == 1) 
        {
            Instantiate(potiondrop, transform.position, Quaternion.identity);

            potiontimer += Time.deltaTime;
            potiondrops = 0;
        }

        if (potiontimer >= 2)
        {
            potiontimer = 0;
            potiondrops = 1;
        }
            
    }
    private void AmmoDropping()
    {
        if(ammoTimer == 0 && ammoDrops == 1)
        {
            Instantiate(ammoDrop, transform.position, Quaternion.identity);
            ammoTimer += Time.deltaTime;
            ammoDrops = 0;
        }
        if(potiontimer >= 2)
        {
            potiontimer = 0;
            ammoDrops = 1;
        }
      
    }
}

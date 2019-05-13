using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
    public Explosion expSense;
    public Hp_scipt playerHp;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && expSense.Trigger == true)
        {
            playerHp.Hpremaining = playerHp.Hpremaining - 2;
        }
    }
}

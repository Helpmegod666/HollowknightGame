using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{
    public Hp_scipt player;
    public JumpFeedback feedback;
    public bool dead;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (dead == false)
        {
            if (collision.tag == "Player" && player.immunityframe == false)
            {
                player.Damage();
                feedback.Shake(0.1f, 0.2f);
            }
        }

         
    }
}

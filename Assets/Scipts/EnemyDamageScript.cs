using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageScript : MonoBehaviour
{
    public Hp_scipt player;
    public JumpFeedback feedback;
    public bool dead;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (dead == false)
        {
            if (collision.gameObject.tag == "Player" && player.immunityframe == false)
            {
                player.Damage();
                //feedback.Shake(0.1f, 0.1f);
            }
        }
    }





}

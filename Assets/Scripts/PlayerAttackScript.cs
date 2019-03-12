using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{


    public Transform attackHitbox;
    public EnemyHealth enemyHp;
    public SpriteRenderer enemySprite;
 
    // Update is called once per frame
    void Update()
    {
        if (AttackScript.canAttack == true && Input.GetKeyDown(KeyCode.Z))
        {
            enemyHp.Health -= 1;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            attackHitbox.localPosition = new Vector3(0, 0.7f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            attackHitbox.localPosition = new Vector3(0, -0.9f);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            attackHitbox.localPosition = new Vector3(1, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            attackHitbox.localPosition = new Vector3(-1, 0);
        }
    }

}

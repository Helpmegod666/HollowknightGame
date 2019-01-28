using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    public GameObject enemyToAttack;
    public Transform attackHitbox;
    // Update is called once per frame
    void Update()
    {
        if (AttackScript.canAttack == true && Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(enemyToAttack);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            attackHitbox.localPosition = new Vector3(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            attackHitbox.localPosition = new Vector3(0, -1);
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

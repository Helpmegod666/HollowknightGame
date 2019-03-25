using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttacksScript : MonoBehaviour
{
    public int ammo = 5;
    public Transform attackHitbox;
    public GameObject bulletPrefab;
    public PlayerAttackScript normalAttack;
    public bool shootLeft = false;
    public bool shootRight = true;
    public bool shootUp = false;
    public bool shootDown = false;
    private void Start()
    {
        attackHitbox = GetComponent<Transform>();
    }
    private void Update()
    {
        if(ammo <= 0)
        {
            normalAttack.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            attackHitbox.localPosition = new Vector3(0, 0.7f);
            shootDown = false;
            shootLeft = false;
            shootRight = false;
            shootUp = true;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            attackHitbox.localPosition = new Vector3(0, -0.7f);
            
            shootLeft = false;
            shootRight = false;
            shootUp = false;
            shootDown = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            attackHitbox.localPosition = new Vector3(0.7f, 0);
            shootDown = false;
            shootLeft = false;
            
            shootUp = false;
            shootRight = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            attackHitbox.localPosition = new Vector3(-0.7f, 0);
            shootDown = false;
            
            shootRight = false;
            shootUp = false;
            shootLeft = true;
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            Shoot();
        }

    }
    void Shoot()
    {
        Instantiate(bulletPrefab, attackHitbox.position, attackHitbox.rotation);
        ammo -= 1;
    }
    
    
}

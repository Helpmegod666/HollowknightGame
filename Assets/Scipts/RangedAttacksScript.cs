using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedAttacksScript : MonoBehaviour
{
    public AudioSource effect;
    bool knockbackRight;
    public int ammo = 5;
    public Transform attackHitbox;
    public GameObject bulletPrefab;
    public PlayerAttackScript normalAttack;
    PlayerMovement playerMovement;
    GameObject playerObj;
    public Quaternion rotationUp;
    public Quaternion rotationDown;
    public bool shootLeft = false;
    public bool shootRight = true;
    public bool shootUp = false;
    public bool shootDown = false;
    private void Start()
    {
        attackHitbox = GetComponent<Transform>();
        playerObj = GameObject.FindGameObjectWithTag("Player");
        playerMovement = playerObj.GetComponent<PlayerMovement>();
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
            attackHitbox.localScale = new Vector3(0.5f, 0.4f, 1);
            attackHitbox.localRotation = rotationUp;
            shootDown = false;
            shootLeft = false;
            shootRight = false;
            shootUp = true;
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            attackHitbox.localPosition = new Vector3(0, -0.7f);
            attackHitbox.localScale = new Vector3(0.5f, 0.4f, 1);
            attackHitbox.localRotation = rotationDown;
            shootLeft = false;
            shootRight = false;
            shootUp = false;
            shootDown = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            attackHitbox.localPosition = new Vector3(1f, 0.1f);
            attackHitbox.localScale = new Vector3(0.5f, 0.4f, 1);
            attackHitbox.localRotation = new Quaternion(0, 0, 0, 0);
            shootDown = false;
            shootLeft = false;
            
            shootUp = false;
            shootRight = true;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            attackHitbox.localPosition = new Vector3(-1f, 0.1f);
            attackHitbox.localScale = new Vector3(-0.5f, 0.4f, 1);
            attackHitbox.localRotation = new Quaternion(0, 0, 0, 0);
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
        effect.Play();
        if(shootRight == true)
        {
            playerMovement.knockFromRight = true;
        }
        else
        {
            playerMovement.knockFromRight = false;
        }
        
        playerMovement.knockbackCount = playerMovement.knockbackLength / 2;
        Instantiate(bulletPrefab, attackHitbox.position, attackHitbox.rotation);
        ammo -= 1;
    }


}

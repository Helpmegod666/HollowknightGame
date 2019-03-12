using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public RangedAttacksScript player;
    public GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Attack");
        player = playerObj.GetComponent<RangedAttacksScript>();
     
        if(player.shootRight == true)
        {
            rb.velocity = transform.right * speed;
        }
        if (player.shootLeft == true)
        {
            rb.velocity = transform.right * -speed;
        }
        if (player.shootUp == true)
        {
            rb.velocity = transform.up * speed;
        }
        if (player.shootDown == true)
        {
            rb.velocity = transform.up * -speed;
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Destroy(gameObject);
    }

}

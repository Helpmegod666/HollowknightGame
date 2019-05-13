using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideBomber : MonoBehaviour
{
    public GameObject explosion;
    public float player;
    public float enemy; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if(collision.tag == "Player")
    //    {
    //        Destroy(gameObject);
    //        Instantiate(explosion, transform.position, transform.rotation);
    //    }
    //}
}

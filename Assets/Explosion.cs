using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject soundEffect;
    public GameObject playerObject;
    public GameObject explosion;
    public GameObject bomb;
    public float player;
    public float enemy;
    public bool Trigger;
    public Hp_scipt playerHp;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        playerHp = playerObject.GetComponent<Hp_scipt>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(soundEffect);
            playerHp.Hpremaining -= 2;
            Destroy(bomb, 0.05f);
            Instantiate(explosion, transform.position, transform.rotation);
        }
    }
}

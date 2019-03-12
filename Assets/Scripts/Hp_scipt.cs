using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hp_scipt : MonoBehaviour
{
    public bool immunityframe = false;
    public int maxHP = 3;
    public static int Hpremaining = 3;
    private int PotionsRemaining = 3;
    public string Scenetoload;
    public Transform spawnpoint;
    public Transform playerPos;
    public Color color;
    SpriteRenderer playerSprite;
    PlayerMovement playerMovement;



    public void Start()
    {
        transform.position = spawnpoint.position;
        playerSprite = GetComponent<SpriteRenderer>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Checkpoint")
        {
            spawnpoint = collision.transform;
            //spawnpoint.position = Checkpoint_script.Checkpoint.position;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            transform.position = spawnpoint.position;
        }

        if (Input.GetKeyDown(KeyCode.H) && PotionsRemaining > 0)
        {
            Hpremaining = maxHP;
            PotionsRemaining = PotionsRemaining - 1;
        }

        if (Hpremaining <= 0)
        {
            Hpremaining = maxHP;
            playerPos.position = spawnpoint.position;
        }

        print(Hpremaining);
    }

    void Immunity()
    {
        immunityframe = false;
    }
    void ChangeColor()
    {
        playerSprite.color = new Color(0,0.1f, 1);
    }



    public void Damage()
    {
        Hpremaining = Hpremaining - 1;
        playerSprite.color = color;
        immunityframe = true;

        Invoke("Immunity", 1.5f);

        Invoke("ChangeColor", 1.5f);
        
    }
}

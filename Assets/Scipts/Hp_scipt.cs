using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hp_scipt : MonoBehaviour
{
    private bool immunityframe = false;
    public int maxHP = 5;
    public int Hpremaining = 5;
    private int PotionsRemaining = 1;

    public GameObject hpremoved1;
    public GameObject hpremoved2;

    public string Scenetoload;

    public Transform spawnpoint;
    public Transform playerPos;
    public GameObject potion; 

    public void Start()
    {
        transform.position = spawnpoint.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy" && immunityframe == false)
        {
            Hpremaining = Hpremaining - 1;
            print(Hpremaining);

            immunityframe = true;
            Invoke("Immunity", 1f);
        }

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

        if (Input.GetKeyDown(KeyCode.Z) && PotionsRemaining > 0)
        {
            Hpremaining = maxHP;
            PotionsRemaining = PotionsRemaining - 1; 
        }

        if (PotionsRemaining == 1)
        {
            potion.gameObject.SetActive(true);
        }

        if (PotionsRemaining == 0)
        {
            potion.gameObject.SetActive(false);
        }

        if (Hpremaining <= 0)
        {
            Hpremaining = maxHP;
            playerPos.position = spawnpoint.position;
        }

        if (Hpremaining == 3)
        {
            hpremoved1.gameObject.SetActive(true);
            hpremoved2.gameObject.SetActive(true);
        }

        if (Hpremaining == 2)
        {
            hpremoved1.gameObject.SetActive(false);
            hpremoved2.gameObject.SetActive(true);
        }

        if (Hpremaining == 1)
        {
            hpremoved1.gameObject.SetActive(false);
            hpremoved2.gameObject.SetActive(false);
        }
        
    }

    void Immunity()
    {
        immunityframe = false;
    }
}

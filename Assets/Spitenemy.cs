using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spitenemy : MonoBehaviour
{
    public AudioSource spitEffect;
    public GameObject spit;
    public Transform Player;
    public Collider2D Range;
    public DetectionSpit DetectionS;
    EnemyHealth health;
    public float shootinterval = 2;
    public float ShotTimer = 0;

    // will be used for Health later
    private void Start()
    {
        health = GetComponent<EnemyHealth>();
    }

    private Vector3 v_diff;
    private float atan2;

    void Update()
    {
        if (DetectionS.detected == true && health.dead  == false)
        {
           v_diff = (Player.position - transform.position);
           atan2 = Mathf.Atan2(v_diff.y, v_diff.x);
           transform.rotation = Quaternion.Euler(0f, 0f, atan2 * Mathf.Rad2Deg);

            Shoot();
        }
    }

    public void Shoot()
    {
        ShotTimer += Time.deltaTime;

        if (ShotTimer > shootinterval)
        {
            spitEffect.Play();
            Instantiate(spit, transform.position, Quaternion.identity);

            ShotTimer = 0;
        }
    }
}

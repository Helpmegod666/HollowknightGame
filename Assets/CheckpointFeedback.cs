using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointFeedback : MonoBehaviour
{
    SpriteRenderer sprite;
    Color baseColor;
    public Color color;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        baseColor = sprite.color;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            sprite.color = color;
            Invoke("ResetColor", 2f);
        }
    }
    void ResetColor()
    {
        sprite.color = baseColor;
    }
}

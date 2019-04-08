using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartDisabler : MonoBehaviour
{
    public Hp_scipt hp;
    public SpriteRenderer heart1;
    public SpriteRenderer heart2;
    public SpriteRenderer heart3;
    public Sprite fullHeart;
    public Sprite brokenHeart;

    void Update()
    {
        if (hp.Hpremaining == 3)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = fullHeart;
        }

        if (hp.Hpremaining == 2)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = fullHeart;
            heart3.sprite = brokenHeart;
        }

        if (hp.Hpremaining == 1)
        {
            heart1.sprite = fullHeart;
            heart2.sprite = brokenHeart;
            heart3.sprite = brokenHeart;
        }

        if (hp.Hpremaining == 0)
        {
            heart1.sprite = brokenHeart;
            heart2.sprite = brokenHeart;
            heart3.sprite = brokenHeart;
        }
    }
}

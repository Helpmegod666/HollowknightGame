using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUI : MonoBehaviour
{
    public Hp_scipt hp;
    SpriteRenderer icon;
    private void Start()
    {
        icon = GetComponent<SpriteRenderer>();
        icon.enabled = true;
    }
    private void Update()
    {
        if (hp.PotionsRemaining >= 1)
        {
            icon.enabled = true;
        }
        if (hp.PotionsRemaining <= 0)
        {
            icon.enabled = false;
        }
    }
}

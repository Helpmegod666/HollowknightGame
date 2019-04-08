using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionUI : MonoBehaviour
{
    public Hp_scipt hp;
    SpriteRenderer icon;
    public Sprite fullPotion;
    public Sprite usedPotion;
    private void Start()
    {
        icon = GetComponent<SpriteRenderer>();
        icon.enabled = true;
    }
    private void Update()
    {
        if (hp.PotionsRemaining >= 1)
        {
            icon.sprite = fullPotion;
        }
        if (hp.PotionsRemaining <= 0)
        {
            icon.sprite = usedPotion;
        }
    }
}

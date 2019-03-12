using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BarNpc : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        text.text = string.Format("Hej");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpFeedback : MonoBehaviour
{
    Camera mainCam;
    float shakeAmount = 0;
    void Start()
    {
            mainCam = Camera.main;
        
    }

    public void Shake(float amt, float length)
    {
        shakeAmount = amt;
        InvokeRepeating("BeginShake", 0, 0.01f);
        Invoke("StopShake", length);
    }
    void BeginShake()
    {
        if(shakeAmount > 0)
        {
            Vector3 camPos = mainCam.transform.position;
            float offsetX = Random.value * shakeAmount * 2 - shakeAmount;
            float offsetY = Random.value * shakeAmount * 2 - shakeAmount;
            camPos.x += offsetX;
            camPos.y += offsetY;
            mainCam.transform.position = camPos;
        }

    }
    void StopShake()
    {
        CancelInvoke("BeginShake");
        mainCam.transform.localPosition = Vector3.zero;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text RealTimer;
    void Start()
    {
        GetCurrentTime();
    }

    private void GetCurrentTime()
    {
        string DayTime = DateTime.Now.ToString("t");
        RealTimer.text = DayTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

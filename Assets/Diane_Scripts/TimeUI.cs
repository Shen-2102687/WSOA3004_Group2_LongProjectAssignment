using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TimeUI : MonoBehaviour
{

    public TextMeshProUGUI timeText;

     private void OnEnable()
    {
        TimeManager.onMinuteChanged += UpdateTime;
        TimeManager.onHourChanged += UpdateTime;
    }

    private void OnDisable()
    {
        TimeManager.onMinuteChanged -= UpdateTime;
        TimeManager.onHourChanged -= UpdateTime;

    }

    private void UpdateTime()
    {
        timeText.text = $"{TimeManager.Hour:00} : {TimeManager.Minute:00}";
    }
}

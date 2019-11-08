using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    public Transform hoursTransform;
    public Transform minTransform;
    public Transform secTransform;
    const float degreesPerHour = 30f;
    const float degreesPerMin = 6f;
    const float degreesPerSec = 6f;
    public bool continuous;

    void Update()
    {
        if (continuous)
        {
            UpdateContinuous();
        }
        else
        {
            UpdateDiscrete();
        }
    }
    void UpdateContinuous()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        //   Debug.Log(DateTime.Now);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalHours * degreesPerHour, 0f);
        minTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalMinutes * degreesPerMin, 0f);
        secTransform.localRotation =
            Quaternion.Euler(0f, (float)time.TotalSeconds * degreesPerSec, 0f);

    }
    void UpdateDiscrete()
    {
        DateTime time = DateTime.Now;
        //   Debug.Log(DateTime.Now);
        hoursTransform.localRotation =
            Quaternion.Euler(0f, time.Hour * degreesPerHour, 0f);
        minTransform.localRotation =
            Quaternion.Euler(0f, time.Minute * degreesPerMin, 0f);
        secTransform.localRotation =
            Quaternion.Euler(0f, time.Second * degreesPerSec, 0f);

    }
}

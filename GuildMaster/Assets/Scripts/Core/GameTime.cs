using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class GameTime : MonoBehaviour
{

    [SerializeField] private float minutesForDay;
    [SerializeField] private float secondsForDay;

    private bool day = false;
    private float secondsLeft = -1f;

    // Update is called once per frame
    void Update()
    {
        if (day)
        {
            secondsLeft -= Time.deltaTime;
            if (secondsLeft < 0)
            {
                day = false;
            }
        }
    }

    public void startDay()
    {
        day = true;
        secondsLeft = minutesForDay * 60 + secondsForDay;
    }

    public bool Day()
    {
        return day;
    }

    public float SecondsLeft()
    { 
        return secondsLeft; 
    }
}

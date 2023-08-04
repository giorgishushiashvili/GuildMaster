using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class GameTime : MonoBehaviour
{
    public GameObject city;

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
                endDay();
            }
        }
    }

    public void startDay()
    {
        day = true;
        secondsLeft = minutesForDay * 60 + secondsForDay;
    }

    public void endDay()
    {
        day = false;
        city.GetComponent<CityManager>().EndOfDay();
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

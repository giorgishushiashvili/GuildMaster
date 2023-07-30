using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    [SerializeField]
    private float secondsTillEnd;
    [SerializeField]
    private float minutesTillEnd;


    private bool day;
    private float timeTillEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (day)
        {
            if (timeTillEnd > 0) 
            { 
                timeTillEnd -= Time.deltaTime;
            }
            else
            {
                day = false;
            }
        }
    }

    private void StartDay()
    {
        day = true;
        timeTillEnd = minutesTillEnd * 60f + secondsTillEnd;
    }

    /// <summary>
    /// If true currently is day
    /// else it is night;
    /// </summary>
    /// <returns></returns>
    public bool Day()
    {
        return day;
    }

    /// <summary>
    /// End the day and go to the night
    /// </summary>
    public void SkipDay()
    {
        day = false;
        timeTillEnd = -1f;
    }
}

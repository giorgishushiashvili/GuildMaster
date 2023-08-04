using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using Unity.VisualScripting;

public class UIDisplay : MonoBehaviour
{
    //TODO rewrite and delete.
    public TMP_Text dayNightClock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float Time = this.GetComponent<GameTime>().SecondsLeft();
        if ( Time > 0)
        {
            dayNightClock.text = Time.ToString();
        }
        else
        {
            dayNightClock.text = "Currently is night";
        }
    }
}

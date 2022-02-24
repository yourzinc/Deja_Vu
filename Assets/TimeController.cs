using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    private int time;
    DayController today;
    // Start is called before the first frame update
    void Start()
    {
        time = 1;
        today = GameObject.Find("Day").GetComponent<DayController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getTime()
    {
        return time;
    }

    public void TimePass()
    {
        time++;
        if (time > 4)
        {
            today.DayPass();
            time %= 4;
        }
    }
}

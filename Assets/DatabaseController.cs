using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseController : MonoBehaviour
{
    private int [,]_note_database;
    //private int _note_database_size;
    // Start is called before the first frame update
    void Start()
    {
        //_note_database_size = 0;
        _note_database = new int[21, 5]; // Day = 20¿œ. Time = 4∞≥
        for (int i = 0; i < 20; i++)
            for (int j = 0; j < 4; j++)
                _note_database[i, j] = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    public int get_Note(int day, int time)
    {
        return _note_database[day, time];
    }

    public void Save_Note(int noteID)
    {
        DayController _now_day = GameObject.Find("Day").GetComponent<DayController>();
        TimeController _now_time = GameObject.Find("Time").GetComponent<TimeController>();
        DejavuController _devaju = GameObject.Find("Dejavu").GetComponent<DejavuController>();
        
        int day = _now_day.getDay();
        int time = _now_time.getTime();

        _note_database[day, time] = noteID;

        if (time == 4)
        {
            
            bool dejavu = Dejavu(day, noteID);
            
            if (dejavu == true)
            {
                _now_day.Dejavu();
                // Game Over
                _devaju.start_playALL(day);
                return;
            }
        }

        //TimePass()
        _now_time.TimePass();
    }

    bool Dejavu(int day, int noteID)
    {
        for (int i=1; i<day; i++)
        {
            if (_note_database[i, 1] == _note_database[day,1] &&
                _note_database[i, 2] == _note_database[day,2] &&
                _note_database[i, 3] == _note_database[day,3] &&
                _note_database[i, 4] == noteID )
                    return true;
        };

        return false;
    }

}


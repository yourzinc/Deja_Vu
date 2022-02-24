using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NoteController : MonoBehaviour
{
    public int _note_ID;
    public AudioSource sound;

    DayController _now_day;
    TimeController _now_time;
    DatabaseController _database;

    // Start is called before the first frame update
    void Start()
    {
        _now_day = GameObject.Find("Day").GetComponent<DayController>() ;
        _now_time = GameObject.Find("Time").GetComponent<TimeController>();
        _database = GameObject.Find("Database").GetComponent<DatabaseController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        sound.Play();
        _database.Save_Note(_note_ID);


        int t = _now_time.getTime();

        switch (t)
        {
            case 1:
                Camera.main.GetComponent<Skyboxcontroller>().Morning();
                break;
            case 2:
                Camera.main.GetComponent<Skyboxcontroller>().Afternoon();
                break;
            case 3:
                Camera.main.GetComponent<Skyboxcontroller>().Evening();
                break;
            case 4:
                Camera.main.GetComponent<Skyboxcontroller>().Night();
                break;

        } 
    }
}


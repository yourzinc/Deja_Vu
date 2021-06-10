using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayController : MonoBehaviour
{
    TextMeshPro _text_Day;
    private int day = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getDay()
    {
        return day;
    }

    public void DayPass()
    {
        day += 1;
        Awake();
    }

    private void Awake()
    {
        _text_Day = GameObject.Find("Day").GetComponent<TextMeshPro>();
        _text_Day.text = day.ToString();
    }

    public void Dejavu()
    {
        _text_Day.text = "Deja Vu!";
    }
}

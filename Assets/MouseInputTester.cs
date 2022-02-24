using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInputTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Down");
        }
        if(Input.GetMouseButton(0))
        {
            Debug.Log("Hold");
        }    
        if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Up");
        }
    }
}

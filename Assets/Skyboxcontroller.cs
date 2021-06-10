using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyboxcontroller : MonoBehaviour
{
    public Material sky_morning;
    public Material sky_afternoon;
    public Material sky_evening;
    public Material sky_night;

    // Start is called before the first frame update
    void Start()
    { 
        RenderSettings.skybox = sky_morning;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Morning()
    {
        RenderSettings.skybox = sky_morning;
    }
   
    public void Afternoon()
    {
        RenderSettings.skybox = sky_afternoon;
    }

    public void Evening()
    {
        RenderSettings.skybox = sky_evening;
    }
    public void Night()
    {
        RenderSettings.skybox = sky_night;
    }
}

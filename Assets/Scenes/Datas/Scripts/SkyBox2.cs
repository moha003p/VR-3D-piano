
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBox2 : MonoBehaviour {

    public Material skyOne;
    public Material skyTwo;
    public Material skyThree;


    // Use this for initialization
    void Start()
    {

        RenderSettings.skybox = skyTwo;

    }

    // Update is called once per frame
    void Update()
    {

    }
}


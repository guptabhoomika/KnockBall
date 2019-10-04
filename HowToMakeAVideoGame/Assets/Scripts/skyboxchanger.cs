using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxchanger : MonoBehaviour
{
    public GameObject player;
    public Material[] skybox;

    void Start()
    {
        RenderSettings.skybox = skybox[0];
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z<250)
        {
            RenderSettings.skybox = skybox[0];
        }
        else if (player.transform.position.z >= 250 && player.transform.position.z < 500)
        {
            RenderSettings.skybox = skybox[1];
        }
        else if (player.transform.position.z > 500 && player.transform.position.z <= 1000)
        {
            RenderSettings.skybox = skybox[2];
        }
        else if (player.transform.position.z > 1000 && player.transform.position.z <= 1500)
        {
            RenderSettings.skybox = skybox[3];
        }
        else 
        {
            RenderSettings.skybox = skybox[4];
        }

    }
}

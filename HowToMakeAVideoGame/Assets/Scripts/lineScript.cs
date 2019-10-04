using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineScript : MonoBehaviour
{
   public LineRenderer linerender;
   public GameObject cube;

    void Start()
    {
        linerender = GetComponent<LineRenderer>();
        cube = GameObject.FindGameObjectWithTag("Player");
        linerender.SetPosition(0, cube.transform.position);
        linerender.SetWidth(0.5F, 0.5F);
    }

    // Update is called once per frame
    void Update()
    {
        linerender.SetPosition(1, cube.transform.position);
    }
}

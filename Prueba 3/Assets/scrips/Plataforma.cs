using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    [SerializeField] PlatformEffector2D plataforma;
    void Start()
    {
        plataforma = GetComponent<PlatformEffector2D>();
        plataforma.rotationalOffset = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") < 0)
        {
            plataforma.rotationalOffset = 180;
        } else
        {
            plataforma.rotationalOffset = 0;
        }
    }
}

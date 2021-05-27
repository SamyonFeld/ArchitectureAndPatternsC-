using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drone
{
    public GameObject drone;
    public float maxForce = 80.0f;
    public float minForce = 0.0f;

    public Drone(GameObject _drone)
    {
        drone = _drone;
    }
}

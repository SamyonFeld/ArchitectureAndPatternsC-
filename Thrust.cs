using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : IThrustable
{    
    public void AddThrustForce(Rigidbody unit, float force, float minForce, float maxForce)
    {
        unit.AddForce(unit.transform.up * Mathf.Clamp(force, minForce, maxForce));
        //if (force != 0) { Debug.Log(Mathf.Clamp(force, minForce, maxForce)); }
    }
}

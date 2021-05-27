using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : IMovable
{
    public float AddControlForce(float maxObjectForce)
    {
        return Input.GetAxis("Vertical") * maxObjectForce;
    }
}

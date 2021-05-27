using UnityEngine;

public interface IThrustable
{
    void AddThrustForce(Rigidbody unit, float force, float maxForce, float minForce);
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] GameObject drone;
    Drone _drone;
    Rigidbody _droneBody;
    IThrustable _thrust;
    IMovable _move;
    private float verticalForce;
    void Start()
    {
        _drone = new Drone(drone);
        _droneBody = _drone.drone.GetComponent<Rigidbody>();
        _thrust = new Thrust();
        _move = new Move();
    }

    private void Update()
    {
        if(Input.GetAxis("Vertical") !=0 || Input.GetAxis("Horizontal") != 0)
        {
            verticalForce = _move.AddControlForce(_drone.maxForce);
        }
    }
    void FixedUpdate()
    {
        _thrust.AddThrustForce(_droneBody, verticalForce, _drone.minForce, _drone.maxForce);
    }
}

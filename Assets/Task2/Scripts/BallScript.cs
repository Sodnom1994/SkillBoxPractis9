using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody _ballRigidBody;

    public float power;

    void Start()
    {
        _ballRigidBody = ball.GetComponent<Rigidbody>();
        _ballRigidBody.AddForce(Vector3.forward * power);
    }
}

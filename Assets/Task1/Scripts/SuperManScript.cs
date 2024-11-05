using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperManScript : MonoBehaviour
{
    public GameObject superMan;
    public GameObject[] badGuys;

    public Rigidbody[] badGuysRigidBody;
    private Rigidbody _superManRigidBody;

    private Vector3 _directionalAway;

    private int _count = 2;

    [SerializeField] private float _force = 35;
    private float _distance;
    private float _speed = 0.05f;
    private void Update()
    {
        if (_count >= 0)
        {
            _distance = Vector3.Distance(superMan.transform.position, badGuys[_count].transform.position);
            _directionalAway = badGuys[_count].transform.position - superMan.transform.position;
            superMan.transform.LookAt(badGuys[_count].transform.position);
            superMan.transform.position = Vector3.MoveTowards(superMan.transform.position, badGuys[_count].transform.position, _speed);
            if (_distance < 0.1)
            {
                badGuysRigidBody[_count].AddForce(_directionalAway.normalized * _force, ForceMode.Impulse);
                _count--;
            }
        }
        if (_count < 0)
        {
            Vector3 fly = new(0, 5, 0);
            _superManRigidBody = superMan.GetComponent<Rigidbody>();
            superMan.transform.position = Vector3.MoveTowards(superMan.transform.position, fly, _speed);
            if (superMan.transform.position == fly)
            {
                _superManRigidBody.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
    }
}

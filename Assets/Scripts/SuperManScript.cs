using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperManScript : MonoBehaviour
{
    private GameObject _superMan;
    public GameObject[] badGuys;
    private Rigidbody[] _badGuysRigidBody;

    private float _tick = 3f;
    private float _distance;
    private float _force;
    [SerializeField] private float _speed;

    private ForceMode _forceMode; 

    private void Start()
    {
        _superMan = GetComponent<GameObject>();
        for (int i = 0; i < badGuys.Length; i++)
        {
            badGuys[i] = GetComponent<GameObject>();
            _badGuysRigidBody[i] = badGuys[i].GetComponent<Rigidbody>();
            _distance = Vector3.Distance(_superMan.transform.position, badGuys[i].transform.position);
            _superMan.transform.position = Vector3.MoveTowards(_superMan.transform.position, badGuys[i].transform.position, _speed);
            if(_distance <=0.2f)
            {
                //_badGuysRigidBody[i].AddForce()
            }
        }
    }
    //void Update()
    //{
    //    _tick -= Time.deltaTime;
    //    if (_tick <= 0)
    //    {



    //        _tick = 3f;
    //    }

    //}
}

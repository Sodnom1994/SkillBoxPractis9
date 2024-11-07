using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsInTubeScript : MonoBehaviour
{

    public MeshCollider tube;
    public MeshCollider tube2;

    private Rigidbody _rigidBody;
    private void Start()
    {
        GetComponent<GameObject>();
        _rigidBody = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == tube)
        {


        }

    }
    private void OnTriggerExit(Collider other)
    {
        
    }
}

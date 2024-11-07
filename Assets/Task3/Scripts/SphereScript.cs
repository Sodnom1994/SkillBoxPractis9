using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SphereScript : MonoBehaviour
{
    public GameObject sphereGameObject;
    private SphereCollider _sphereCollider;
    private void Start()
    {
        _sphereCollider = GetComponent<SphereCollider>();

    }
    private void Update()
    {
       
    }
    private void OnCollisionExit(Collision collision)
    {
        
    }
}

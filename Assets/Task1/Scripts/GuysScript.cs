using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuysScript : MonoBehaviour
{

    public GameObject[] goodGuys;
    public GameObject[] badGuys;

    void Start()
    {
        for (int i = 0; i < goodGuys.Length; i++)
        {
            badGuys[i].transform.LookAt(goodGuys[i].transform);
        }
        for (int i = 0; i < badGuys.Length; i++)
        {
            goodGuys[i].transform.LookAt(badGuys[i].transform);
        }
    }
}

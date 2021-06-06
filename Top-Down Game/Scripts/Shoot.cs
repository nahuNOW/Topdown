using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class Shoot : MonoBehaviour
{
    public GameObject shot;
    private Transform playerPos;

    void Start()
    {
        playerPos = GetComponent<Transform>();
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Instantiate(shot, playerPos.position, Quaternion.identity);
        }
    }
}

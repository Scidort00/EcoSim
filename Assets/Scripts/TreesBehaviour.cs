﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreesBehaviour : MonoBehaviour
{
    public GameObject Trunk;

    private Vector3 RandomPos;

    void Start()
    {
        //StartCoroutine(GenerateTree());
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown("space"))
        {
            RandomPos = new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));
            Instantiate(Trunk, RandomPos, new Quaternion(0, 0, 0, 0));
        }
        //StartCoroutine(GenerateTree());
    }

    /*IEnumerator GenerateTree()
    {
       for(int i=0;i<9;i=0) {
            if (Input.GetKeyDown("space")) {
                yield return new WaitForSeconds(Random.Range(2f, 10f));
                RandomPos = new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-5.0f, 5.0f));
                Instantiate(Trunk, RandomPos, new Quaternion(0, 0, 0, 0));
            }
        } 
    }*/

}

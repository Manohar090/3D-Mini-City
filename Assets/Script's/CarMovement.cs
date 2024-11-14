using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private float c=0f;
    public GameObject tester;
    public float timer = 72;
    
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        c += Time.deltaTime;
        if(c>timer)
        {
            tester.SetActive(true);
            transform.Translate(Vector3.forward * Time.deltaTime * 1);
        }
    }
}

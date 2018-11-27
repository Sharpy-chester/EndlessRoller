﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject shot;
    public float shootForce = 10;

    void Update()
    {
        //Vector3 spawnAt = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        if (Input.GetMouseButtonDown(0))
        {
            Ray RayDir = (Camera.main.ScreenPointToRay(Input.mousePosition));

            Vector3 x = ((RayDir.direction + Camera.main.transform.position) - RayDir.origin);
            GameObject B = Instantiate(shot, Camera.main.transform.position, Quaternion.identity);
            B.GetComponent<Rigidbody>().AddForce(x * shootForce);
        }
    }
}

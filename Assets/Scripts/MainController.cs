using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject shot;
    public float forcez = 10f;
    public float forcey = 10f;


    void Update()
    {
        Vector3 spawnAt = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        if (Input.GetMouseButtonDown(0))
        {
            
            GameObject cube = Instantiate(shot, spawnAt, Camera.main.transform.rotation);
            cube.transform.parent = this.transform;
            cube.GetComponent<Rigidbody>().AddForce(0, forcey, forcez);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotCol : MonoBehaviour {



    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Breakable")
        {
            Destroy(col.gameObject);
        }
    }
}

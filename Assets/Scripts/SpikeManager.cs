using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeManager : MonoBehaviour {



    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Ball")
        {
            Destroy(col);
        }
    }
}

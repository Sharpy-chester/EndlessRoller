using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour {

    public GameObject shot;
    public float shootForce = 10;
    public SectionManager sectionManager;

    void Awake()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray RayDir = (Camera.main.ScreenPointToRay(Input.mousePosition));

            Vector3 x = ((RayDir.direction + Camera.main.transform.position) - RayDir.origin);
            GameObject B = Instantiate(shot, Camera.main.transform.position, Quaternion.identity);
            B.GetComponent<Rigidbody>().AddForce(x * shootForce);
            Destroy(B, 10);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "KillOnContact")
        {
            sectionManager.GameOver("Killed by spikes");
        }
    }

    void OnCollisionStay(Collision col)
    {
        if (col.gameObject.name == "Cube (6)")
        {
            col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-4, -15, 0));
        }
    }
}

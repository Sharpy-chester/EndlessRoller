using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SectionManager : MonoBehaviour {

    public List<GameObject> sections;
    public GameObject ball;
    public GameObject ballObjForSpawn;

	void Start () {
		
	}
	
	void Update () {
        if (ball.transform.position.x >= ballObjForSpawn.transform.position.x)
        {
            int randomNum = Random.Range(0, sections.Count);
            Debug.Log(randomNum);
            
            ballObjForSpawn.transform.localPosition = new Vector3(ballObjForSpawn.transform.localPosition.x + 12, ballObjForSpawn.transform.localPosition.y, ballObjForSpawn.transform.localPosition.z);
            GameObject section = Instantiate(sections[randomNum], new Vector3(ballObjForSpawn.transform.position.x, ballObjForSpawn.transform.position.y, ballObjForSpawn.transform.position.z), this.transform.rotation);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Section : MonoBehaviour {

    public int sectionID;
    SectionManager sectionManager;

	void Awake () {
        sectionManager = GameObject.Find("SectionManager").GetComponent<SectionManager>();
	}
	
	void Update () {
		if (sectionID + 3 == sectionManager.sectionID)
        {
            Destroy(this.gameObject);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBall : MonoBehaviour {

    public GameObject ball;
	
	void Update () {
        this.transform.position = new Vector3(ball.transform.position.x, ball.transform.position.y + 2, this.transform.position.z);
	}
}

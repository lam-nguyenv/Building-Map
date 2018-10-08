using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent2Behavior : MonoBehaviour {
    public Vector2 position;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    public Vector2 Update () {
        return this.transform.position;
    }


}

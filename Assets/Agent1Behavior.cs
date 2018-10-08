using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent1Behavior : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float speed;
    public float moveHorizontal;
    public float moveVertical;
    public Agent2Behavior agent2;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        agent2 = GetComponent<Agent2Behavior>();
    }
	
	// Update is called once per frame
	void Update () {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce (movement * speed);

        Vector2 agent2Position = new Vector2(0, 0);
        agent2Position = agent2.Update();
        Debug.Log("Agent 2 Position: " + agent2Position);

    }


}

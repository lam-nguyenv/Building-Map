using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent1Behavior : MonoBehaviour {
    private Rigidbody2D rb2d;
    public float speed;
    public float moveHorizontal;
    public float moveVertical;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        
    }
	
	// Update is called once per frame
	void Update () {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce (movement * speed);
        Vector2 agent2Position = new Vector2();
        agent2Position = Agent2Behavior.getPosition();
    }


}

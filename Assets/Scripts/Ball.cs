using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour{
    private Paddle paddle;
    private Vector3 paddleToBallVector;

    private bool hasStarted = false;

	// Use this for initialization
	void Start () {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        if (!hasStarted)
        {
            // Lock the ball relative to paddle
            this.transform.position = paddle.transform.position + paddleToBallVector;

            //Starts game and gives ball velocity...waits for mouse press
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 8f);
            }
        }
	}

    void OnCollisionEnter2D(Collision2D collision) {
        Vector2 tweak = new Vector2(Random.Range(0f, 0.2f), Random.Range(0f, 0.1f));
        this.GetComponent<Rigidbody2D>().velocity += tweak;
    }
}

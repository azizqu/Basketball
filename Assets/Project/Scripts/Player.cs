using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Ball ball;
    public GameObject playerCamera;

    public float ballDistance = 2f;

    public float ballThrowingForce = 5f;

    public bool holdingBall = true;




	// Use this for initialization
	void Start () {

        ball.GetComponent<Rigidbody>().useGravity = false;

		
	}
	
	// Update is called once per frame
	void Update () {

        if(holdingBall)
        {
            ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;  // position references point in the world; forward references the direction i.e up down left right; 

            if(Input.GetMouseButton(0))
            {
                holdingBall = false; // release ball
                ball.ActivateTrail();
                ball.GetComponent<Rigidbody>().useGravity = true; // ball drops;

                ball.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * ballThrowingForce); // throw
            }
        }
    }

        
}

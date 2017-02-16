using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public float startForce;

	private Rigidbody2D myRigidBody;

	public GameObject paddle1;
	public GameObject paddle2;

	public GameManager theGM;

	// Use this for initialization
	void Start () {
		myRigidBody = GetComponent<Rigidbody2D>();
		myRigidBody.velocity = new Vector2(startForce, startForce);
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "GoalZone")
		{
			if(transform.position.x < 0)
			{
				transform.position = paddle2.transform.position + new Vector3(-1f, 0, 0);
				myRigidBody.velocity = new Vector2(-startForce, -startForce);
				theGM.UpdateScore(2);
			} else {
				transform.position = paddle1.transform.position + new Vector3(1f, 0, 0);
				myRigidBody.velocity = new Vector2(startForce, startForce);
				theGM.UpdateScore(1);
			}
		}
	}

}
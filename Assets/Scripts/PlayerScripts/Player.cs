using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float movementSpeed = 0.7f;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        Vector3 movement = new Vector3(1,0,0) * movementSpeed * Time.deltaTime;

        rigidBody.MovePosition(transform.position + movement);
	}
}

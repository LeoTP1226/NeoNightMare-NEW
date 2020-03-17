﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowRotateTest : MonoBehaviour
{
    public Transform target;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 5f;
    public Quaternion currentRotation;
    // Start is called before the first frame update
    void Start()
    {

        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;
        float angle =  Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = currentRotation * angle; 
        direction.Normalize();
        movement = direction;
        moveCharacter(movement);

    }

    private void FixedUpdate()
    {
        //moveCharacter(movement);
    }
    void moveCharacter(Vector3 direction)
    {
     rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}


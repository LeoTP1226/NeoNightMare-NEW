using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFollow_V02 : MonoBehaviour
{
   // private GameObject useless;
    public Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindWithTag("Rabbit").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction,  Vector3.up);
        rb.rotation = rotation;
        direction.Normalize();
        movement = direction;

    }
    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }

    
}

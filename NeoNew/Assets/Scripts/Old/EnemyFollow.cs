using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Rabbit");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle; 
        direction.Normalize();
        movement = direction;
        moveCharacter(movement); 

    }

    private void FixUpdate()
    {
        
    }

    void moveCharacter(Vector3 direction)
    {
        rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));
    }
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private GameObject player;
    private Rigidbody rb;
    private Vector3 movement;
    public float moveSpeed = 5f;
    public Transform target;
    public float speed = 1.0f;


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
      //  float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //rb.rotation = angle; 
        //direction.Normalize();
       // movement = direction;
        //moveCharacter(movement);
        //moveCharacter(Vector3 direction);
    
       
        

        Vector3 targetDirection = player.transform.position - transform.position;
         float singleStep = speed * Time.deltaTime;
         Vector3 newDirection = Vector3.RotateTowards(transform.forward, direction, singleStep, 0.0f);
         Debug.DrawRay(transform.position, newDirection, Color.red);
         transform.rotation = Quaternion.LookRotation(newDirection * 180.0f);

       // rb.MovePosition((Vector3)transform.position + (direction * moveSpeed * Time.deltaTime));



    }

    private void FixedUpdate()
    {
        Vector3 direction = player.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, speed * Time.deltaTime);

    }
    
    

   
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    public float moveSpeed;
    Rigidbody m_Rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 3f;
       // m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("Cube");

        // transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        // if (Input.GetKeyDown("w"))
        // {
        //transform.position += transform.forward * Time.deltaTime * moveSpeed;
        // print("Walk");
        //    m_Rigidbody.velocity = transform.forward * moveSpeed;

        //  }

        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0, 0, translation);
      
    }
}

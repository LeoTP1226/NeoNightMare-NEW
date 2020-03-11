using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public static Animator anim;
    public float movespeed = 10.0f;
    public Rigidbody rb;

    public Vector3 moveInput;
    public Vector3 moveVelocity;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
        //Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVelocity = moveInput * movespeed;
        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Plane groundPlane = new Plane(Vector3.up, Vector3.zero);

         float rayLength;

        if (groundPlane.Raycast(cameraRay, out rayLength))
        {
            Vector3 pointToLook = cameraRay.GetPoint(rayLength);
            transform.LookAt(pointToLook);
        }

        if (Input.GetButtonDown("Fire1"))
         {    
            anim.SetTrigger("Hit");
         }
        if (Input.GetAxis("Vertical") != 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}

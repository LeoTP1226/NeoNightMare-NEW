using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FollowTest : MonoBehaviour {
    public GameObject player;
    public float upforce;
    public float forwardforce;
    public Rigidbody rb;
    public float delay;
   
   


    public bool canstep;

	
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        canstep = true;
        player = GameObject.FindGameObjectWithTag("Player");
        
	}
	
	
	void Update () {

        if (canstep)
        {
            StartCoroutine(Step());
        }
		
	}

    public IEnumerator Step()
    {
        canstep = false;
        transform.LookAt(player.transform);
        rb.AddForce(Vector3.up * upforce);
        rb.AddRelativeForce(Vector3.forward * forwardforce);
        yield return new WaitForSeconds(delay);
        canstep = true;

       
    }

     void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
                 
            Destroy(this.gameObject);
        }
    }
}

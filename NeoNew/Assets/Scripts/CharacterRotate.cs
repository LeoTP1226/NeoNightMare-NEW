using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        followmouse(); 
    }

    // Update is called once per frame
    void followmouse()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
       //mouseposition = Camera.main.ScreenToViewportPoint(mouseposition);

        Vector2 direction = new Vector3(mouseposition.x - transform.position.x, mouseposition.y - transform.position.y);
        transform.up = direction;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)==true)
        {
            //rb.AddForce(-speed, 0f, 0f);
            transform.Translate (Vector3.left*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow)==true)
        {
            //rb.AddForce(speed, 0f, 0f);
            transform.Translate (Vector3.right*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow)==true)
        {
            //rb.AddForce(0f, 0f, speed);
            transform.Translate (Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow)==true)
        {
            //rb.AddForce(0f, 0f, -speed);
            transform.Translate (Vector3.back*speed*Time.deltaTime);
        }
    }
}

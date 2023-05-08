using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)==true)
        {
            //rb.AddForce(-speed, 0f, 0f);
            transform.Translate (Vector3.left*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)==true)
        {
            //rb.AddForce(speed, 0f, 0f);
            transform.Translate (Vector3.right*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.W)==true)
        {
            //rb.AddForce(0f, 0f, speed);
            transform.Translate (Vector3.forward*speed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)==true)
        {
            //rb.AddForce(0f, 0f, -speed);
            transform.Translate (Vector3.back*speed*Time.deltaTime);
        }
    }
}

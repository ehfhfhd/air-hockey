using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Shoot(new Vector3(0, 0, 20));
        //}
    }

    public void Shoot(Vector3 dir) //총알 발사 함수
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.tag == "Enemy")
        {
            GameObject manager = GameObject.Find("ScoreManager");
            manager.GetComponent<ScoreManager>().IncScore();
            Destroy(gameObject, 0.2f);
        }

        if (coll.collider.tag == "Wall")
        {
            Destroy(gameObject, 0.2f);
        }
    }
}

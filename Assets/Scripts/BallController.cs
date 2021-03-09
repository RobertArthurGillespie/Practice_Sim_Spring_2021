using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    Camera camera;
    [SerializeField]
    float force;
    [SerializeField]
    float jumpForce;
   
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Movement());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator Movement()
    {
        while (true)
        {
            //CrappyFade();
            //this.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
            //this.gameObject.GetComponent<Rigidbody>().AddTorque(Vector3.forward * torqueForce);
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");
            //this.gameObject.transform.Translate(horizontal, 0, vertical);

            if (vertical > 0)
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce(camera.gameObject.transform.forward * force);
            }
            if (horizontal > 0)
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce(camera.gameObject.transform.right * force);
            }
            if (vertical < 0)
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce((-1) * (camera.gameObject.transform.forward * force));
            }
            if (horizontal < 0)
            {
                this.gameObject.GetComponent<Rigidbody>().AddForce((-1) * (camera.gameObject.transform.right * force));
            }
           
            yield return null;
        }
    }

    
}

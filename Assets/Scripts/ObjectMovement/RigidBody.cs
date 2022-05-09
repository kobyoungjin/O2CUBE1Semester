using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    public float force = 300.0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))  
        {   // ↑키로 안쪽 방향.
            this.transform.GetComponent<Rigidbody>().AddForce(Vector3.forward * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) 
        {   // ↓키로 앞쪽 방향.
            this.transform.GetComponent<Rigidbody>().AddForce(Vector3.back * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {   // ←키로 왼쪽 방향.
            this.transform.GetComponent<Rigidbody>().AddForce(Vector3.left * force * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {   //→키로 오른쪽 방향.
            this.transform.GetComponent<Rigidbody>().AddForce(Vector3.right * force * Time.deltaTime);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        Move();
    }
 
    private void Move()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        { // ↑키로 forward(전).
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { // ↓키로 back(후).
            this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { // ←키로 left(좌).
            this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { // →키로 right(우).
            this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        }
    }
}

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
        { // ��Ű�� forward(��).
            this.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        { // ��Ű�� back(��).
            this.transform.Translate(Vector3.back * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        { // ��Ű�� left(��).
            this.transform.Translate(Vector3.left * 3.0f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        { // ��Ű�� right(��).
            this.transform.Translate(Vector3.right * 3.0f * Time.deltaTime);
        }
    }
}

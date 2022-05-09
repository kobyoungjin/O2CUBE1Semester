using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 10f);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }
}

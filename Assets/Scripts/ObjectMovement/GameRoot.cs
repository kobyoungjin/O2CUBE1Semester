using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
    private GameObject prefab = null;

    void Start()
    {
        prefab = Resources.Load<GameObject>("Prefabs/Player");
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // prefab�������� ������� GameObject�� ������.
            GameObject go = GameObject.Instantiate(this.prefab) as GameObject;
            // ������ GameObject�� ������ ����.
            float x = Random.Range(-10.0f, 10.0f);
            float z = Random.Range(-5.0f, 5.0f);
            go.transform.position = new Vector3(x, 1.0f, z);
        }
    }
}

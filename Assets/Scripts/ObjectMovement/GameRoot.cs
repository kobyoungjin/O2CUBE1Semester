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
            // prefab변수에서 만들어진 GameObject를 가져옴.
            GameObject go = GameObject.Instantiate(this.prefab) as GameObject;
            // 가져온 GameObject의 설정을 변경.
            float x = Random.Range(-10.0f, 10.0f);
            float z = Random.Range(-5.0f, 5.0f);
            go.transform.position = new Vector3(x, 1.0f, z);
        }
    }
}

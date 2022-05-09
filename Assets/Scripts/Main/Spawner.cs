using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject wallPrefab;
    public float interval;
    public float range = 3.0f;

    IEnumerator Start()
    {
        while (true)
        {  // y��ǥ�� �����ϰ� ���� 
            transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation);
            // �÷��� �����͸� �ϳ��� return �� ���� ���� ��ġ ���
            yield return new WaitForSeconds(interval);
        }

    }
}

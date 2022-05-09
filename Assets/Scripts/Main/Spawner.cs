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
        {  // y좌표만 랜덤하게 생성 
            transform.position = new Vector3(transform.position.x, Random.Range(-range, range), transform.position.z);
            Instantiate(wallPrefab, transform.position, transform.rotation);
            // 컬렉션 데이터를 하나씩 return 후 다음 실행 위치 기억
            yield return new WaitForSeconds(interval);
        }

    }
}

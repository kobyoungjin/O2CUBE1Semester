using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float jumpPower;

    private void Start()
    {
  
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);  // jumpPower 만큼 위로 이동
        
    }

    private void OnCollisionEnter(Collision collision)  // 오브젝트에 충돌시
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // 현재 씬으로 재시작
    }
}

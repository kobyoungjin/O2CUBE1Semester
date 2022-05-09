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
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);  // jumpPower ��ŭ ���� �̵�
        
    }

    private void OnCollisionEnter(Collision collision)  // ������Ʈ�� �浹��
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // ���� ������ �����
    }
}

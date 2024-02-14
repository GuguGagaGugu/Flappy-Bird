using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BirdScript : MonoBehaviour
{
    public LogicScript logic;
    public Rigidbody2D myRigidBody;

    public float initialSpeed = 5f; // ��������� �������� ������
    public float acceleration = 0.1f; // ����������� ���������

    private float birdStartVelocity = 16f;
    static public bool birdisAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdisAlive)
        {
            myRigidBody.velocity = Vector2.up * birdStartVelocity;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)//���� ������� ����������
    {
        logic.gameOver();
        birdisAlive = false;
    }


}

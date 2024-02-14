using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public LogicScript score;

    private float startMoveSpeed = 10f;
    private float currentMoveSpeed;
    private float maxSpeed = 30f;
    private float accelerationRate = 0.1f;


    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        currentMoveSpeed = startMoveSpeed;
    }


    void Update()
    {
        transform.Translate(Vector3.left * currentMoveSpeed * Time.deltaTime);
        currentMoveSpeed += accelerationRate * Time.deltaTime;
        currentMoveSpeed = Mathf.Min(currentMoveSpeed, maxSpeed);
        Debug.Log(currentMoveSpeed);
        PipeCheck();
        //if (transform.position.x < -35f)
        //{
        //    Debug.Log("Pipe deleted");
        //    Destroy(gameObject);
            
        //}
        
    }


    private void PipeCheck()
    {
        if (transform.position.x < -35f)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);

        }
    }

}



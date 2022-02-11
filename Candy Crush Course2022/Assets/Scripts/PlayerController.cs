using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool canMove = true;
    [SerializeField] float speedMove;
    [SerializeField] float maxPos;

    void Start()
    {
        
    }
    
    void Update()
    {
        if(canMove)
        {
            Move();
        }
    }

    private void Move()
    {
        float inputX = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * inputX * speedMove * Time.deltaTime;
        float xPos = Mathf.Clamp(transform.position.x, -maxPos, maxPos);
        transform.position = new Vector3(xPos, transform.position.y, transform.position.z);
    }
}

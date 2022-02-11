using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInvoke : MonoBehaviour
{
    [SerializeField] GameObject target;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        Vector3 newPos = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.y);
        transform.LookAt(newPos);
    }
}

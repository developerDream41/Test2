using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCamera : MonoBehaviour
{
    Transform camTrans;

    public float shakeTime;
    public float shakeRange;

    Vector3 originalPosition;

    void Start()
    {
        camTrans = Camera.main.transform;
        originalPosition = camTrans.position;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            StartCoroutine(CameraShake());
        }
    }

    IEnumerator CameraShake()
    {
        float elapsedTime = 0;
        while(elapsedTime<shakeTime)
        {
            Vector3 pos= originalPosition + Random.insideUnitSphere * shakeRange;
            pos.z = originalPosition.z;
            camTrans.position = pos;
            elapsedTime += Time.deltaTime;

            yield return null;
        }
        camTrans.position = originalPosition;
    }
}

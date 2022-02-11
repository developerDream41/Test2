using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public int minZoom2d, maxZoom2d;
    public int zoomSpeed2D;

    public int minZoom3d, maxZoom3d;
    public int zoomSpeed3D;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Camera.main.orthographic)
        {
            if(Input.GetAxis("Mouse ScrollWheel") >0)
            {
                Camera.main.orthographicSize -= zoomSpeed2D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.orthographicSize += zoomSpeed2D * Time.deltaTime;
            }
            Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom2d, maxZoom2d);
        }
        else
        {

            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                Camera.main.fieldOfView -= zoomSpeed3D * Time.deltaTime;
            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                Camera.main.fieldOfView += zoomSpeed3D * Time.deltaTime;
            }
            Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, minZoom3d, maxZoom3d);
        }
    }
}

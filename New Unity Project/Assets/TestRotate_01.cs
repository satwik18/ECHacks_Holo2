using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRotate_01 : MonoBehaviour
{
    public float horizontalSpeed = 10.0F;
    public float verticalSpeed = 10.0F;
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
}
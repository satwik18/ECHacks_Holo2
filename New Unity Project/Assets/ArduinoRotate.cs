using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoRotate : MonoBehaviour {

    public float xzSpeed = 10.0F;
    public float xySpeed = 10.0F;
    public float yzSpeed = 10.0F;

    SerialPort sp = new SerialPort("COM1", 9600);

    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    void Update()
    {
        string value = sp.ReadLine();
        string[] vec3 = value.Split(' ');
        float yAngle = float.Parse(vec3[0]);
        float zAngle = float.Parse(vec3[1]);
        float xAngle = float.Parse(vec3[2]);
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
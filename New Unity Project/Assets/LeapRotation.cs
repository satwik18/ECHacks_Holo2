using InteractionEngineUtility;
using Leap.Unity.Interaction.Internal;
using Leap.Unity.RuntimeGizmos;
using Leap.Unity.Space;
using Leap.Unity.Query;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap.Unity.Attributes;


public class LeapRotation : MonoBehaviour {

    public float horizontalSpeed = 10.0F;
    public float verticalSpeed = 10.0F;
    //float pitch = hand.Direction.Pitch;
    //float yaw = hand.Direction.Yaw;
    //float roll = hand.PalmNormal.Roll;

    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(v, h, 0);
    }
}

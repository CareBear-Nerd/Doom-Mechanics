// Author: Kieran B.
// Date: 24/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	#region Variables
    [Header("Look Sensitivity Settings")]
	public bool xyMatch = true;
    public float lookSensitivity = 1.0f;
	public float lookSensitivityX = 1.0f;
    public float lookSensitivityY = 1.0f;
    [Range(0.0f,1.0f)] public float lookSmoothTime = 0.5f; 

    [Header("Speed/Accelration")]
    public float walkSpeed = 6.0f;
    [Range(0.0f,1.0f)] public float moveAccel = 0.5f; 
    
	#endregion

    /*void FixedUpdate()
    {
        if (lookSensitivityMatch)
        {
            lookSensitivityX = lookSensitivity;
            lookSensitivityY = lookSensitivity;
        }
    }*/
}
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

    [Header("Movement Profile")]
    public MovementProfile moveProf;

    [Header("Speed/Accelration Settings")]
    public float walkSpeed = 0.0f;
    public float gravity = -9.8f;
    [Range(0.0f,1.0f)] public float moveAccel = 0.0f; 
    
    [Header("Jump Settings")]
    public float jumpHeight = 0.0f;
    public int maxJumps = 1;

	#endregion

    /*void FixedUpdate()
    {
        if (lookSensitivityMatch)
        {
            lookSensitivityX = lookSensitivity;
            lookSensitivityY = lookSensitivity;
        }
    }*/

    void Awake() 
    {
        if (moveProf!=null)
        {
            gravity = moveProf.gravity;
            walkSpeed = moveProf.walkSpeed;
            moveAccel = moveProf.moveAccel;
            // = moveProf.airAccel;
            jumpHeight = moveProf.jumpHeight;
            maxJumps = moveProf.maxJumps;
            Debug.Log("Applied movement profile: " + moveProf.profName);
        }
    }
}
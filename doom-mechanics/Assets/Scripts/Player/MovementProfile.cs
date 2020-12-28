// Author: Kieran B.
// Date: 28/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Movement Profile", menuName = "Movement Profile")]
public class MovementProfile : ScriptableObject
{
    public string profName;

    [Header("Physics Settigns")]
    public float gravity = -9.8f;
	
    [Header("Movement Settings")]
    public float walkSpeed = 0.0f;
    [Range(0.0f,1.0f)]public float moveAccel = 0.0f;
    public float airAccel = 0.0f;

    [Header("Jump Settings")]
    public float jumpHeight = 0.0f;
    [Range(0,20)] public int maxJumps = 1; 
}
// Author: Kieran B.
// Date: 24/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
	#region Variables
	
    //input variables
    public Vector2 moveAxis, lookAxis;
	public float jumpInput, dashInput, primFireInput, secFireInput;

    //debug
    [SerializeField] private bool debugConsoleOutputs = false;

	#endregion
	
	#region Input System Event Functions

    public void OnMove(InputAction.CallbackContext ctx)
    {
        moveAxis = ctx.ReadValue<Vector2>();

        if (debugConsoleOutputs)
            Debug.Log("MOVE: " + moveAxis);
    }

    public void OnLook(InputAction.CallbackContext ctx)
    {
        lookAxis = ctx.ReadValue<Vector2>();

        if (debugConsoleOutputs)
            Debug.Log("LOOK: " + lookAxis);
    }

	public void OnJump(InputAction.CallbackContext ctx)
    {
        jumpInput = ctx.ReadValue<float>();

        if (debugConsoleOutputs)
            Debug.Log("JUMP: " + jumpInput);
    }

    public void OnDash(InputAction.CallbackContext ctx)
    {
        dashInput = ctx.ReadValue<float>();

        if (debugConsoleOutputs)
            Debug.Log("DASH: " + dashInput);
    }

    public void OnPrimaryFire(InputAction.CallbackContext ctx)
    {
        primFireInput = ctx.ReadValue<float>();

        if (debugConsoleOutputs)
            Debug.Log("PRIMARY FIRE: " + primFireInput);
    }

    public void OnSecondaryFire(InputAction.CallbackContext ctx)
    {
        secFireInput = ctx.ReadValue<float>();

        if (debugConsoleOutputs)
            Debug.Log("SECONDARY FIRE: " + secFireInput);
    }

    
	
	#endregion
}
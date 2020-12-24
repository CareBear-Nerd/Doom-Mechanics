// Author: Kieran B.
// Date: 24/12/2020

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	#region Variables

    [SerializeField] PlayerInputs inputs = null;
    [SerializeField] PlayerMovement movement = null;
	[SerializeField] Transform playerCameraPivot = null;
    [SerializeField] bool lockCursor = true;

    float cameraPitch, velY, lookSensX, lookSensY;
    CharacterController controller = null;

	Vector2 currentDir, currentDirVel, currentLookDelta, currentLookDeltaVel = Vector2.zero;

	#endregion
	
	#region Start/Update Functions
	
    void Start()
    {
        controller = GetComponent<CharacterController>();

        if(lockCursor)
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
    }

    void Update()
    {
        LookSensitivityToUse(movement.xyMatch, movement.lookSensitivity, movement.lookSensitivityX, movement.lookSensitivityY);
        UpdateLook();
        UpdateMove();
    }
	
	#endregion
    void LookSensitivityToUse(bool xyMatch, float ls, float lsX, float lsY)
    {
        if (xyMatch)
        {
            lookSensX = ls;
            lookSensY = ls;
        }
        else
        {
            lookSensX = lsX;
            lookSensY = lsY;
        }
    }

    void UpdateLook()
    {
        Vector2 targetLookDelta = inputs.lookAxis;
        currentLookDelta = Vector2.SmoothDamp(currentLookDelta, targetLookDelta, ref currentLookDeltaVel, movement.lookSmoothTime);
        cameraPitch -= currentLookDelta.y * lookSensY;
        cameraPitch = Mathf.Clamp(cameraPitch,-85.0f, 85.0f);
        playerCameraPivot.localEulerAngles = Vector3.right * cameraPitch;
        transform.Rotate(Vector3.up * currentLookDelta.x * lookSensX);
    }

    void UpdateMove()
    {
        Vector2 targetDir = inputs.moveAxis;
        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVel, movement.moveAccel);

        if (controller.isGrounded)
            velY = 0.0f;

        velY += movement.gravity * Time.deltaTime;

        Vector3 vel = (transform.forward * currentDir.y + transform.right * currentDir.x) * movement.walkSpeed + Vector3.up * velY;
        controller.Move(vel * Time.deltaTime);
    }
}
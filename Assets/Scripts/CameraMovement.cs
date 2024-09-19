using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMovement : MonoBehaviour
{
    InputMaster cameraInputMaster;

    private bool rotateR;
    private bool rotateL;

    [SerializeField] GameObject target;
    [SerializeField] private float _distanceFromTarget = 3;

    private float _mouseSensevity;
    private float _rotationY;
    private float _rotationX;

    private void Awake()
    {
        //cameraInputMaster = new InputMaster();
        //cameraInputMaster.Camera.Enable();
        //cameraInputMaster.Camera.RotateL.started += PressQ;
        //cameraInputMaster.Camera.RotateR.started += PressE;
    }
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = new Quaternion(30, -45, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //if (rotateR)
        //{
        //    transform.Rotate(0, transform.rotation.y + 30, 0);
        //    rotateR = false;
        //}

        //if (rotateL)
        //{
        //    transform.Rotate(0, transform.rotation.y - 30, 0);
        //    rotateL = false;
        //}


        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        _rotationX += mouseY;
        _rotationY += mouseX;

        _rotationX = Mathf.Clamp(_rotationX, -40, 40);

        transform.localEulerAngles = new Vector3(_rotationX + 30, _rotationY-45, 0);

        transform.position = target.transform.position - transform.forward * _distanceFromTarget;

    }

    private void PressQ(InputAction.CallbackContext context)
    {
        rotateL = true;
    }

    private void PressE(InputAction.CallbackContext context)
    {
        rotateR = true;
    }

}

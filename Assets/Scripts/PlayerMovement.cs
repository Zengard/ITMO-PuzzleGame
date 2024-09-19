using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    //private Rigidbody playerRB;
    private CharacterController playerCharacterController;

    protected InputMaster playerInputMaster;
    protected Animator playerAnimator;

    [SerializeField] protected float speed;
    [SerializeField] protected float Run;
    protected float _defaultSpeed;


    //store players input values
    private Vector3 movementVector;
    private Vector2 inputVector;
    private Vector3 inputDirection;

    //gravity variables
    private float gravity = -9.8f;
    private float groundGravity = -0.5f;// gravity when you walk

    //jumping variables
    private bool isJumpPressed = false;
    private float initialJumpVelicity;
    public float maxJumpHeight = 1f;
    public float maxJumpTime = 0.5f;
    private bool isJumping = false;

    //collider for groundCheck
    private float detectCollider;
    public float TEST;

    //animation
    protected int isWalkingHash;
    protected int isJumpingHash;

    //rotation variables
    public float rotationFactorPerFrame = 1f;
    private bool rotateR;
    private bool rotateL;
    private float _targetRotation = 0.0f;
    private float _rotationVelocity;

    //switch character
    public bool freezeMovement = false;

    public bool RotateR => rotateR;
    public bool RotateL => rotateL;

    private void Awake()
    {
        //playerRB = GetComponent<Rigidbody>();
        playerCharacterController = GetComponent<CharacterController>();

        //stepRayUpper.transform.position = new Vector3(stepRayUpper.transform.position.x, stepHeight, stepRayUpper.transform.position.z);

        playerAnimator = GetComponent<Animator>();
        detectCollider = GetComponent<CapsuleCollider>().bounds.extents.y;

        isWalkingHash = Animator.StringToHash("isWalking");
        isJumpingHash = Animator.StringToHash("isJumping");

        playerInputMaster = new InputMaster();
        playerInputMaster.Player.Enable();
        playerInputMaster.Player.SwitchCharacter.started += SwitchCharacter;

        SetUpJump();

        _defaultSpeed = speed;
    }


    private void Update()
    {
        SetUpJump();
        inputVector = playerInputMaster.Player.Movement.ReadValue<Vector2>();

        if (freezeMovement == true)
        {
            inputVector = Vector2.zero;

        }   

        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;
        forward.y = 0;
        right.y = 0;
        forward = forward.normalized;
        right = right.normalized;

        Vector3 forwardRelativeVerticalInput = inputVector.y * forward;
        Vector3 rightRelativeVerticalInput = inputVector.x * right;

        Vector3 cameraRelativeMovement = forwardRelativeVerticalInput + rightRelativeVerticalInput;
        cameraRelativeMovement.y = movementVector.y;

        playerCharacterController.Move(cameraRelativeMovement * speed * Time.deltaTime);


        if (inputVector != Vector2.zero)
        {
            Vector3 positionToLookAt;
            positionToLookAt.x = cameraRelativeMovement.x;
            positionToLookAt.y = 0;
            positionToLookAt.z = cameraRelativeMovement.z;

            // rotate to face input direction relative to camera position
            Quaternion targetDirection = Quaternion.LookRotation(positionToLookAt);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetDirection, rotationFactorPerFrame * Time.deltaTime);
        }
    }



    private void FixedUpdate()
    {
        HandleGravity();    
    }

    private void SwitchCharacter(InputAction.CallbackContext context)
    {
        if(freezeMovement == true)
        {
            freezeMovement = false;
        }
        else if(freezeMovement == false)
        {
            freezeMovement = true;
        }
    }

    private void Jump(InputAction.CallbackContext context)
    {
        isJumpPressed = context.ReadValueAsButton();
    }

    private void HandleJump()
    {
        if (isJumpPressed == true && isJumping == false && CheckGround())
        {
            playerAnimator.SetBool(isJumpingHash, true);

            isJumping = true;
            movementVector.y = initialJumpVelicity * 0.5f;
        }
        else if (isJumpPressed == false && isJumping == true && CheckGround())
        {
            isJumping = false;
        }
    }

    private void SetUpJump() // Jump  physics 
    {
        float timeToApex = maxJumpTime / 2;
        gravity = -2 * maxJumpHeight / Mathf.Pow(timeToApex, 2);
        initialJumpVelicity = (2 * maxJumpHeight) / timeToApex;
    }


    private void StopMove()
    {

    }

    private void ContinueMove()
    {   
        speed = _defaultSpeed;
    }  
   
    private void HandleAnimation()
    {
        if (inputVector.y != 0 || inputVector.x != 0)
        {
            playerAnimator.SetBool(isWalkingHash, true);
        }
        else if (inputVector.y == 0 || inputVector.x == 0)
        {
            playerAnimator.SetBool(isWalkingHash, false);
        }
    }

    private void HandleRotation()
    {
        Quaternion currentRotation = transform.rotation;
        if (inputVector.x > 0 && inputVector.x <= 1)
        {
            rotateR = true;
            rotateL = false;
        }
        else if (inputVector.x >= -1 && inputVector.x < 0)
        {
            rotateR = false;
            rotateL = true;
        }

        if (rotateR == true)
        {
            Quaternion targertRotation = Quaternion.Euler(new Vector2(0, 0));

            if (inputVector.x > 0 && inputVector.y > 0)
            {
                targertRotation = Quaternion.Euler(new Vector2(0, -45));
            }
            else if (inputVector.x > 0 && inputVector.y < 0)
            {
                targertRotation = Quaternion.Euler(new Vector2(0, 45));
            }


            transform.rotation = Quaternion.Lerp(currentRotation, targertRotation, rotationFactorPerFrame * Time.deltaTime);
        }
        else if (rotateL == true)
        {
            Quaternion targertRotation = Quaternion.Euler(new Vector2(0, 180));

            if (inputVector.x < 0 && inputVector.y > 0)
            {
                targertRotation = Quaternion.Euler(new Vector2(0, 225));
            }
            else if (inputVector.x < 0 && inputVector.y < 0)
            {
                targertRotation = Quaternion.Euler(new Vector2(0, 135));
            }

            transform.rotation = Quaternion.Lerp(currentRotation, targertRotation, rotationFactorPerFrame * Time.deltaTime);
        }

    }



    private void HandleGravity()
    {
        bool isFalling = movementVector.y <= 0 || isJumpPressed == false;
        float fallMultiplier = 2f;

        if (playerCharacterController.isGrounded)
        {
            movementVector.y = groundGravity;
        }

        else if (isFalling)
        {
            float previousYVelocity = movementVector.y;
            float newYVelocity = movementVector.y + (fallMultiplier * gravity * Time.deltaTime);
            float nextYVelocity = Mathf.Max((previousYVelocity + newYVelocity) * 0.5f, -20.0f);
            movementVector.y = nextYVelocity;
        }
        else
        {
            float previousYVelocity = movementVector.y;
            float newYVelocity = movementVector.y + (gravity * Time.deltaTime);
            float nextYVelocity = (previousYVelocity + newYVelocity) * 0.5f;
            movementVector.y = nextYVelocity;
        }

    }

    protected bool CheckGround()
    {
        LayerMask playerMask = 1 << 3;

        if (Physics.Raycast(transform.position - new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down), detectCollider + 0.1f, playerMask)
            || Physics.Raycast(transform.position + new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down), detectCollider + 0.1f, playerMask))
        {
            Debug.DrawRay(transform.position - new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down) * (GetComponent<CapsuleCollider>().bounds.extents.y + 0.1f), Color.green);
            Debug.DrawRay(transform.position + new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down) * (GetComponent<CapsuleCollider>().bounds.extents.y + 0.1f), Color.green);
            return true;
        }
        else
        {           
            Debug.DrawRay(transform.position - new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down) * (GetComponent<CapsuleCollider>().bounds.extents.y + 0.1f), Color.red);
            Debug.DrawRay(transform.position + new Vector3(GetComponent<CapsuleCollider>().bounds.extents.x * TEST, 0, 0), transform.TransformDirection(Vector2.down) * (GetComponent<CapsuleCollider>().bounds.extents.y + 0.1f), Color.red);
            return false;
        }
    }

    private void OnEnable()
    {
        playerInputMaster.Player.Enable();
    }

    private void OnDisable()
    {
        playerInputMaster.Player.Disable();
    }

}

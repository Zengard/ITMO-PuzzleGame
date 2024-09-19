using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPress : MonoBehaviour
{
    private Vector3 originPosition;
    private Vector3 pressedPosition;
    private float speed = 3;

    private bool isPressed = false;


    public GameObject obstacle;
    public Vector3 obstacleNewPosition;
    private Vector3 obstacleOriginPositon;

    private MoveCube moveCube;

    private void Start()
    {
        originPosition = transform.position;
        pressedPosition = new Vector3(originPosition.x, originPosition.y - 0.2f, originPosition.z);
        obstacleOriginPositon = obstacle.transform.position;

        moveCube = obstacle.GetComponent<MoveCube>();
    }


    private void FixedUpdate()
    {
        if(isPressed == false)
        {
            obstacle.transform.position = Vector3.Lerp(obstacle.transform.position, new Vector3(obstacleOriginPositon.x, obstacleOriginPositon.y, obstacleOriginPositon.z), speed * Time.deltaTime);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isPressed = true;
            transform.position = Vector3.Lerp(transform.position, pressedPosition, speed * Time.deltaTime);
            obstacle.transform.position = Vector3.Lerp(obstacle.transform.position, new Vector3(obstacleNewPosition.x, obstacleNewPosition.y, obstacleNewPosition.z), speed * Time.deltaTime);

            //moveCube.MoveObject(obstacleOriginPositon, new Vector3(obstacleNewPosition.x, obstacleNewPosition.y, obstacleNewPosition.z));
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Left button");

            isPressed = false;
            transform.position = originPosition;
        }       
    }


   
}

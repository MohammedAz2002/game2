using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class playercontrollercar : MonoBehaviour
{


    public float moveSpeed = 10f; // movement speed in units per second
    public float turnRadius = 5f; // turning radius in units
    public float turnSpeed = 60f; // turning speed in degrees per second
    public Transform frontLeftWheel;
    public Transform frontRightWheel;
    public Transform cameraTransform;

    PhotonView view;
    private void Start()
    {
        view = GetComponent<PhotonView>();
        if (!view.IsMine)
        {
            cameraTransform.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (view.IsMine)
        {
            // Turn the front wheels left/right based on the "A" and "D" keys
            float turnInput = Input.GetAxis("Horizontal");
            frontLeftWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);
            frontRightWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);

            // Move the car forward/backward based on the "W" and "S" keys
            float moveInput = Input.GetAxis("Vertical");

            if (moveInput != 0)
            {
                // Calculate the turn angle based on the move direction and turn radius
                float turnAngle = Mathf.Atan2(turnRadius, Mathf.Abs(moveInput)) * Mathf.Rad2Deg;

                // Apply the turn angle to the car's rotation
                transform.Rotate(Vector3.up, turnInput * turnAngle * Time.deltaTime, Space.World);

                // Move the car forward
                transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);
            }
        }

    }
}



//public class playercontrollercar : MonoBehaviour
//{


//    public float moveSpeed = 10f; // movement speed in units per second
//    public float turnRadius = 5f; // turning radius in units
//    public float turnSpeed = 60f; // turning speed in degrees per second
//    public Transform frontLeftWheel;
//    public Transform frontRightWheel;
//    public Transform cameraTransform;

//    PhotonView view;
//    private void Start()
//    {
//        view = GetComponent<PhotonView>();
//        if (!view.IsMine)
//        {
//            cameraTransform.gameObject.SetActive(false);
//        }
//    }

//    private void Update()
//    {
//        if (view.IsMine)
//        {
//            // Turn the front wheels left/right based on the "A" and "D" keys
//            float turnInput = Input.GetAxis("Horizontal");
//            frontLeftWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);
//            frontRightWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);

//            // Move the car forward/backward based on the "W" and "S" keys
//            float moveInput = Input.GetAxis("Vertical");

//            if (moveInput != 0)
//            {
//                // Calculate the turn angle based on the move direction and turn radius
//                float turnAngle = Mathf.Atan2(turnRadius, Mathf.Abs(moveInput)) * Mathf.Rad2Deg;

//                // Apply the turn angle to the car's rotation
//                transform.Rotate(Vector3.up, turnInput * turnAngle * Time.deltaTime, Space.World);

//                // Move the car forward
//                transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);
//            }
//        }

//}








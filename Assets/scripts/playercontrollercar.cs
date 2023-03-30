using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrollercar : MonoBehaviour
{


    public float moveSpeed = 10f; // movement speed in units per second
    public float turnRadius = 5f; // turning radius in units
    public float turnSpeed = 60f; // turning speed in degrees per second
    public Transform frontLeftWheel;
    public Transform frontRightWheel;

    private void Update()
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









    //public float speed = 10f; // movement speed in units per second
    //public float turnSpeed = 50f; // turning speed in degrees per second
    //public float turnRadius = 5f; // radius of the turn
    //public Transform frontLeftWheel;
    //public Transform frontRightWheel;

    //private void Update()
    //{
    //    // Turn the front wheels left/right based on the "A" and "D" keys
    //    float turnInput = Input.GetAxis("Horizontal");
    //    frontLeftWheel.localRotation = Quaternion.Euler(0f, -turnInput * 45f, 0f);
    //    frontRightWheel.localRotation = Quaternion.Euler(0f, -turnInput * 45f, 0f);

    //    // Move the car forward/backward based on the "W" and "S" keys
    //    float moveInput = Input.GetAxis("Vertical");

    //    // Calculate the turn direction based on the input
    //    Vector3 turnDirection = Vector3.zero;
    //    if (turnInput < 0)
    //    {
    //        turnDirection = -transform.right;
    //    }
    //    else if (turnInput > 0)
    //    {
    //        turnDirection = transform.right;
    //    }

    //    // Calculate the target position based on the turn direction and radius
    //    Vector3 targetPosition = transform.position + turnDirection * turnRadius;

    //    // Interpolate between the current position and target position based on the move input
    //    transform.position = Vector3.Lerp(transform.position, targetPosition, Mathf.Abs(moveInput));

    //    // Rotate the car towards the turn direction
    //    if (turnDirection != Vector3.zero)
    //    {
    //        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(turnDirection), Time.deltaTime * turnSpeed);
    //    }

    //    // Move the car forward/backward
    //    transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);
    //}







    //public float speed = 5f; // movement speed in units per second
    //public float turnSpeed = 2f; // turning speed in degrees per second
    //public float wheelBase = 5f; // distance between front and rear wheels
    //public float wheelAngle = 25f; // maximum wheel angle in degrees

    //public Transform frontLeftWheel;
    //public Transform frontRightWheel;
    //public Transform rearLeftWheel;
    //public Transform rearRightWheel;



    //private void Update()
    //{
    //    // Turn the front wheels left/right based on the "A" and "D" keys
    //    float turnInput = Input.GetAxis("Horizontal");
    //    frontLeftWheel.localRotation = Quaternion.Euler(0f, -turnInput * 45f, 0f);
    //    frontRightWheel.localRotation = Quaternion.Euler(0f, -turnInput * 45f, 0f);

    //    // Move the car forward/backward based on the "W" and "S" keys
    //    float moveInput = Input.GetAxis("Vertical");

    //    // Calculate the movement vector based on the input
    //    Vector3 movement = new Vector3(turnInput, 0f, moveInput).normalized * speed * Time.deltaTime;

    //    // Apply the movement to the car's transform
    //    transform.Translate(movement, Space.Self);

    //    // Turn the rear wheels based on the movement direction
    //    if (movement.magnitude > 0f)
    //    {
    //        float turnAngle = Mathf.Atan2(movement.x, movement.z) * Mathf.Rad2Deg;
    //        rearLeftWheel.localRotation = Quaternion.Euler(0f, turnAngle, 0f);
    //        rearRightWheel.localRotation = Quaternion.Euler(0f, turnAngle, 0f);
    //    }



    //}




    //    // Turn the front wheels left/right based on the "A" and "D" keys
    //    float turnInput = Input.GetAxis("Horizontal");
    //    frontLeftWheel.localRotation = Quaternion.Euler(0f, turnInput* wheelAngle, 0f);
    //    frontRightWheel.localRotation = Quaternion.Euler(0f, turnInput* wheelAngle, 0f);

    //    // Move the car forward/backward based on the "W" and "S" keys
    //    float moveInput = Input.GetAxis("Vertical");
    //    transform.Translate(Vector3.forward* moveInput * speed * Time.deltaTime);

    //        // Calculate the turn radius based on the wheel angle and wheel base
    //        float turnRadius = 0f;
    //        if (turnInput != 0f)
    //        {
    //            turnRadius = wheelBase / Mathf.Sin(Mathf.Deg2Rad* wheelAngle * Mathf.Abs(turnInput));
    //        }
    //        else
    //{
    //    turnRadius = float.MaxValue;
    //}

    //// Calculate the turn angle based on the turn radius and speed
    //float turnAngle = Mathf.Rad2Deg * moveInput * speed / turnRadius;

    //// Rotate the car based on the turn angle
    //transform.Rotate(Vector3.up, turnAngle);
    //    }


    //private void Update()
    //{
    //    // Turn the front wheels left/right based on the "A" and "D" keys
    //    float turnInput = Input.GetAxis("Horizontal");
    //    frontLeftWheel.localRotation = Quaternion.Euler(0f, turnInput * wheelAngle, 0f);
    //    frontRightWheel.localRotation = Quaternion.Euler(0f,turnInput * wheelAngle, 0f);

    //    // Move the car forward/backward based on the "W" and "S" keys
    //    float moveInput = Input.GetAxis("Vertical");
    //    transform.Translate(Vector3.forward * moveInput * speed * Time.deltaTime);

    //    // Calculate the turn radius based on the wheel angle and wheel base
    //    float turnRadius = wheelBase / Mathf.Sin(Mathf.Deg2Rad * wheelAngle * Mathf.Abs(turnInput));

    //    // Calculate the turn angle based on the turn radius and speed
    //    float turnAngle = Mathf.Rad2Deg * moveInput * speed / turnRadius;

    //    // Rotate the car based on the turn angle
    //    transform.Rotate(Vector3.up, turnAngle);
    //}












    //public Transform frontLeftWheel;
    //public Transform frontRightWheel;
    //public Transform backLeftWheel;
    //public Transform backRightWheel;

    //private void Update()
    //{
    //    // Turn the front wheels left/right based on the "A" and "D" keys
    //    float turnInput = Input.GetAxis("Horizontal");
    //    frontLeftWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);
    //    frontRightWheel.localRotation = Quaternion.Euler(0f, turnInput * 45f, 0f);

    //    // Move the car forward based on the "W" key
    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        // Move the car straight forward
    //        transform.Translate(Vector3.forward * speed * Time.deltaTime);

    //        // Move the car left based on the "A" key
    //        if (Input.GetKey(KeyCode.A))
    //        {
    //            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    //            transform.Translate(Vector3.forward * cornerSpeed * Time.deltaTime);
    //        }

    //        // Move the car right based on the "D" key
    //        if (Input.GetKey(KeyCode.D))
    //        {
    //            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    //            transform.Translate(Vector3.forward * cornerSpeed * Time.deltaTime);
    //        }
    //    }

    //    // Move the car backward based on the "S" key
    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        // Move the car straight backward
    //        transform.Translate(Vector3.back * speed * Time.deltaTime);

    //        // Move the car left based on the "A" key
    //        if (Input.GetKey(KeyCode.A))
    //        {
    //            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    //            transform.Translate(Vector3.back * cornerSpeed * Time.deltaTime);
    //        }

    //        // Move the car right based on the "D" key
    //        if (Input.GetKey(KeyCode.D))
    //        {
    //            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
    //            transform.Translate(Vector3.back * cornerSpeed * Time.deltaTime);
    //        }
    //    }
    //}


}

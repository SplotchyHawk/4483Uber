using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICarScript : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPoint;

    [SerializeField] private Quaternion rotationAmnt;

    [SerializeField] private float motorForce;

    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider;

    private void FixedUpdate()
    {
        HandleMotor();

    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = motorForce;
        frontRightWheelCollider.motorTorque = motorForce;
    }

    private void OnCollisionEnter(Collision collision)
    {
        StartCoroutine(WaitFor3sec());
    }

    IEnumerator WaitFor3sec()
    {
        yield return new WaitForSeconds(3);

        gameObject.SetActive(false);
        transform.position = spawnPoint;
        transform.rotation = rotationAmnt;
    }
}

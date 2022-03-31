using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    private const string HORIZONTAL = "Horizontal";
    private const string VERTICAL = "Vertical";

    private float horizontalInput;
    private float verticalInput;
    private float currentSteeringAngle;
    private float currentBrakingForce;
    private bool IsBraking;

    [SerializeField] private float motorForce, brakeForce, maxSteerAngle;

    [SerializeField] private WheelCollider frontLeftWheelCollider, frontRightWheelCollider, backLeftWheelCollider, backRightWheelCollider;

    [SerializeField] private Transform frontLeftWheelTransform, frontRightWheelTransform, backLeftWheelTransform, backRightWheelTransform;

    Rigidbody m_Rigidbody;
    public float m_Thrust = 10000000000f;

    void Start()
    {
        //Fetch the Rigidbody from the GameObject with this script attached
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        GetInput();
        HandleMotor();
        HandleSteering();
        UpdateWheels();

    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis(HORIZONTAL);
        verticalInput = Input.GetAxis(VERTICAL);
        IsBraking = Input.GetKey(KeyCode.Space);
    }

    private void HandleMotor()
    {
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;

        currentBrakingForce = IsBraking ? brakeForce : 0f;

        ApplyBraking();
    }

    private void ApplyBraking()
    {
        frontLeftWheelCollider.brakeTorque = currentBrakingForce;
        frontRightWheelCollider.brakeTorque = currentBrakingForce;
        backLeftWheelCollider.brakeTorque = currentBrakingForce;
        backRightWheelCollider.brakeTorque = currentBrakingForce;
    }

    private void HandleSteering()
    {
        currentSteeringAngle = maxSteerAngle * horizontalInput;

        frontLeftWheelCollider.steerAngle = currentSteeringAngle;
        frontRightWheelCollider.steerAngle = currentSteeringAngle;
    }

    private void UpdateWheels()
    {
        UpdateSingleWheel(frontLeftWheelCollider, frontLeftWheelTransform);
        UpdateSingleWheel(frontRightWheelCollider, frontRightWheelTransform);
        UpdateSingleWheel(backLeftWheelCollider, backLeftWheelTransform);
        UpdateSingleWheel(backRightWheelCollider, backRightWheelTransform);
    }

    private void UpdateSingleWheel(WheelCollider wheelCollider, Transform wheelTransform)
    {
        Vector3 pos;
        Quaternion rot;

        wheelCollider.GetWorldPose(out pos, out rot);
        wheelTransform.rotation = rot;
        wheelTransform.position = pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Minimize"))
        {
            Vector3 scaleChange = new Vector3(0.5f, 0.5f, 0.5f);

            this.gameObject.transform.localScale = scaleChange;

            Destroy(other.gameObject);

            StartCoroutine(WaitFor8sec());
        }

        else if (other.gameObject.layer == LayerMask.NameToLayer("SpeedBoost"))
        {
            Destroy(other.gameObject);

            m_Rigidbody.AddForce(0, 0, m_Thrust, ForceMode.Impulse);

        }
    }

    IEnumerator WaitFor8sec()
    {
        yield return new WaitForSeconds(8);
        Vector3 scaleChange = new Vector3(1f, 1f, 1f);
        this.gameObject.transform.localScale = scaleChange;
    }
}
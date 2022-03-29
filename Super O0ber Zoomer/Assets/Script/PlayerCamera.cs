using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] public Transform player;
    [SerializeField] public Vector3 thirdPerson;
    [SerializeField] private float translationSpeed;
    [SerializeField] private float rotationSpeed;

    // Update is called once per frame
 
    //transform.position = player.position + thirdPerson;
    private void FixedUpdate()
    {
        HandleTranslation();
        HandleRotation();

    }

    public void HandleTranslation()
    {
        Vector3 targetPosition = player.TransformPoint(thirdPerson);
        transform.position = Vector3.Lerp(transform.position, targetPosition, translationSpeed * Time.deltaTime);
    }

    private void HandleRotation()
    {
        var direction = player.position - transform.position;
        var rotation = Quaternion.LookRotation(direction, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
    }

}

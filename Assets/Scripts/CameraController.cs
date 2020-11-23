using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerPosition;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position - playerPosition.position;
    }
    void Update()
    {
        transform.position = playerPosition.position + initialPosition;
    }
}

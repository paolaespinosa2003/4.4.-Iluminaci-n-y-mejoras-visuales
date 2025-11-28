
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 10f;
    public float horizontalSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector3.forward * forwardSpeed * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * h * horizontalSpeed * Time.deltaTime);
    }
}

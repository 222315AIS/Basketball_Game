using UnityEngine;

public class BallShooter : MonoBehaviour
{
    public float forwardForce = 8f;
    public float upwardForce = 6f;

    private Rigidbody rb;
    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetBall();
        }
    }

    void Shoot()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.AddForce(new Vector3(0f, upwardForce, forwardForce), ForceMode.Impulse);
    }

    void ResetBall()
    {
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = startPosition;
        transform.rotation = startRotation;
    }
}

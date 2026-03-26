using UnityEngine;
using UnityEngine.InputSystem;

public class TorqueControl : MonoBehaviour
{
    public float torqueSpeed = 1.0f;
    private Rigidbody _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if(Keyboard.current.dKey.isPressed)
        {
            _rb.AddRelativeTorque(Vector3.up * torqueSpeed);
        }
    }
}

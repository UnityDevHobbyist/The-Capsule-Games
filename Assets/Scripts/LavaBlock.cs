using UnityEngine;

public class LavaBlock : MonoBehaviour
{
    public float value;
    public Vector3 rotation;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = new Vector3(rotation.x * value, rotation.y * value, rotation.z * value);
    }
}

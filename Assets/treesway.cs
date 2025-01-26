using UnityEngine;

public class LeafSwayAndPulse : MonoBehaviour
{
    public float swayAmount = 5f;      // Maximum sway angle in degrees
    public float swaySpeed = 1f;       // Speed of the swaying motion
    public float scaleAmount = 0.1f;   // Maximum scale change (as a fraction of the original size)
    public float scaleSpeed = 2f;      // Speed of the scaling motion
    public float swayOffset = 0f;      // Offset to randomize sway per leaf
    public float scaleOffset = 0f;     // Offset to randomize scaling per leaf

    private Quaternion initialRotation;
    private Vector3 initialScale;

    void Start()
    {
        initialRotation = transform.localRotation;
        initialScale = transform.localScale;

        // Add random offsets for unique motion per leaf
        swayOffset = Random.Range(0f, Mathf.PI * 2f);
        scaleOffset = Random.Range(0f, Mathf.PI * 2f);
    }

    void Update()
    {
        // Calculate the sway angle
        float swayAngle = Mathf.Sin(Time.time * swaySpeed + swayOffset) * swayAmount;

        // Apply the sway as a local rotation
        transform.localRotation = initialRotation * Quaternion.Euler(0, swayAngle, 0);

        // Calculate the scale adjustment
        float scaleFactor = 1f + Mathf.Sin(Time.time * scaleSpeed + scaleOffset) * scaleAmount;

        // Apply the scaling
        transform.localScale = initialScale * scaleFactor;
    }
}
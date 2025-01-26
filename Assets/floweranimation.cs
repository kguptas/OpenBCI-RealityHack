using UnityEngine;

public class RotateParticleMaterial : MonoBehaviour
{
    public ParticleSystem particleSystem; // Assign in Inspector
    public float rotationSpeed = 10f;     // Rotation speed in degrees per second

    private Material material;
    private float rotation;

    void Start()
    {
        if (particleSystem != null)
        {
            var renderer = particleSystem.GetComponent<ParticleSystemRenderer>();
            material = renderer.material;
        }
    }

    void Update()
    {
        if (material != null)
        {
            rotation += rotationSpeed * Time.deltaTime;
            material.SetFloat("_Rotation", rotation % 360); // "_Rotation" must match the shader's rotation property.
        }
    }
}

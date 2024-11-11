using UnityEngine;

public class ProjectileMotion : MonoBehaviour
{
    public Rigidbody projectile;
    public float initialSpeed = 10f;
    public float angle = 45f;

    private void Start()
    {
        LaunchProjectile();
    }

    public void LaunchProjectile()
    {
        // Convert angle to radians and calculate x, y velocity components
        float radianAngle = angle * Mathf.Deg2Rad;
        float xVelocity = initialSpeed * Mathf.Cos(radianAngle);
        float yVelocity = initialSpeed * Mathf.Sin(radianAngle);

        // Apply velocity to projectile
        projectile.velocity = new Vector3(xVelocity, yVelocity, 0);
    }

    private void Update()
    {
        // Example: Update real-time physics calculations on-screen
        Debug.Log("Current Position: " + projectile.position);
        Debug.Log("Velocity: " + projectile.velocity.magnitude);
    }
}


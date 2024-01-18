using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    public Destoryable health;


    // Rotate left and right
    public Transform horizontalRotateTransform;
    private bool isClockwise = false;

    // Rotate up and down (for the gun barrel)
    public Transform verticalRotateTransform;
    private bool isUp = false;


    // for firing bullets
    public float fireRate = 0.25f;
    public float lastTimeFired = 0;
    public GameObject projectile;
    public Transform bulletFiringPoint;
    public float bulletTravelVelocity = 5f;

    void horizonalRotation()
    {
        float yAngle = horizontalRotateTransform.localRotation.eulerAngles.y;
        if (yAngle <= -20)
        {
            isClockwise = false;

        }
        else if(yAngle >= 20)
        {
            isClockwise = true;
        }
        float deltaAngle = isClockwise ? -0.05f : 0.05f;
        yAngle += deltaAngle;
        Quaternion newRotation = Quaternion.Euler(horizontalRotateTransform.localRotation.eulerAngles.x, yAngle, verticalRotateTransform.localRotation.eulerAngles.z);
        horizontalRotateTransform.localRotation = newRotation;
    }

    void fireProjectile()
    {
        if(Time.time >= lastTimeFired + (1/fireRate))
        {
            GameObject bullet = Instantiate(projectile, bulletFiringPoint.position, bulletFiringPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = horizontalRotateTransform.forward * bulletTravelVelocity;
            lastTimeFired = Time.time;
        }
    }

    void verticalRotation()
    {
        float xAngle = verticalRotateTransform.localRotation.eulerAngles.x;
        if (xAngle <= 320)
        {
            isUp = false;
        }
        else if (xAngle >= 359)
        {
            isUp = true;
        }

        float deltaAngle = isUp ? -0.05f : 0.05f;
        xAngle += deltaAngle;
        Quaternion newRotation = Quaternion.Euler(xAngle, verticalRotateTransform.localRotation.eulerAngles.y, verticalRotateTransform.localRotation.eulerAngles.z);
        verticalRotateTransform.localRotation = newRotation;
    }

    // Update is called once per frame
    void Update()
    {
        if(health.health > 0)
        {
            verticalRotation();
            horizonalRotation();
            fireProjectile();
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

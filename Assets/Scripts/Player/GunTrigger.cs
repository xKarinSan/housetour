using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// source 1: https://www.youtube.com/watch?v=EwiUomzehKU
// source 2: https://www.youtube.com/watch?v=k1kOtaM2NJg
public class GunTrigger : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public Transform userCamera;
    public FPSController fpsController;
    public float bulletLaunchVelocity = 10f;

    void Update()
    {
        float xAngle = userCamera.eulerAngles.x + 90;
        float yAngle = userCamera.eulerAngles.y;
        float zAngle = userCamera.eulerAngles.z;
        gameObject.transform.eulerAngles = new Vector3(xAngle, yAngle, zAngle);

        if (Input.GetMouseButtonDown(0))
        {
            GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletLaunchVelocity;
        }
    }
}

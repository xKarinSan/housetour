using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    // called when script is loaded
    public double bulletDamage = 2;
    private void Awake()
    {

    }

    // called upon collision
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(collision.gameObject);
        //Destoryable collidedObject = collision.
        Destoryable collisionTarget = collision.gameObject.GetComponent<Destoryable>();
        if (collisionTarget != null)
        {
            collisionTarget.health -= bulletDamage;

        }
        Destroy(gameObject);
    }

}

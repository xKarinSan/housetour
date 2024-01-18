using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destoryable : MonoBehaviour
{
    // Start is called before the first frame update
    public double health;

    // Update is called once per frame
    void Update()
    {
        if(health < 0)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRaycast : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        Ray ray;
        ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray,out hit, 5.0f))
        {

        }
    }
}

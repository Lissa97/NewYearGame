using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentDetail : MonoBehaviour
{
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(cam.position.x, transform.position.y, transform.position.z);
    }
}

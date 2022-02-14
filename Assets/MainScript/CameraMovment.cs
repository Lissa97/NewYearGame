using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovment : MonoBehaviour
{
    public Transform player;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _constrainte = transform.position.y;
    }

    float _constrainte;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player.position.y < _constrainte)
            transform.position = new Vector3 (player.position.x, _constrainte, transform.position.z);

        else
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

    }
}

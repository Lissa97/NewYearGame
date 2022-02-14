using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovmentPlayer : MonoBehaviour
{

    Rigidbody2D _rgb;

    public Collider2D groundChecker;
    // Start is called before the first frame update
    void Start()
    {
        _rgb = GetComponent<Rigidbody2D>();
        _rgb.freezeRotation = true;
        _speed = speed;

    }

    bool endJump = false;
    public float speed = 20;
    float _speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxisRaw("Horizontal") < 0 )
        {
            speed -= 0.1f;

            if (speed < 0.2f)
                speed = 0.2f;
        }
        else if(speed <= _speed)
            speed += 0.1f;


        if (Input.GetAxisRaw("Vertical") > 0 && !endJump)
        {

            _rgb.velocity += Vector2.up * 1f;

            if (_rgb.velocity.y > 6f)
                endJump = true;
        }

        if(groundChecker.IsTouchingLayers(~6))
            endJump = false;

        _rgb.velocity = new Vector2(speed, _rgb.velocity.y);
    }
}

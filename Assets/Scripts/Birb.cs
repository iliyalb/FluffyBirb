using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birb : MonoBehaviour
{
    public Rigidbody2D rigidbodyObject;
    public float jumpVelocity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbodyObject.velocity = Vector2.up * jumpVelocity;
        }
    }
}

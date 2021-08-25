using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumperX : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float jumpVelocity = 5f;
            rb2d.velocity = Vector2.up * jumpVelocity;
        }
        
    }
}

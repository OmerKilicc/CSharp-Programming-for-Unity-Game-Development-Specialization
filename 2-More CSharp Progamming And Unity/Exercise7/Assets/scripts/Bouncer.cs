using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : MonoBehaviour
{
    int health = 100;

    Rigidbody2D _rigidbody2D;
    SpriteRenderer _spriteRenderer;
    HUDScript text;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        
        _rigidbody2D.AddForce(10 * Vector2.right,ForceMode2D.Impulse);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        Color colour = _spriteRenderer.color;
        text = GameObject.FindGameObjectWithTag("HUD").GetComponent<HUDScript>();
        text.AddBounce();
        
        colour.a -= 0.1f;
        _spriteRenderer.color = colour;
        health -= 10;
     
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}

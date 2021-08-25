using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
     const float deathTimer = 15f;
     Rigidbody2D _rigidbody2D;
     Timer _timer;
     void Start()
     {
         _timer = GetComponent<Timer>();
         _timer.Duration = deathTimer;
         _timer.Run();
     }

     void Update()
     {
         if (_timer.Finished)
         {
             Destroy(gameObject);
         }
     }

     public void ApplyForce(Vector2 direction)
    {
        const float magnitute = 10f;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.AddForce(magnitute * direction,ForceMode2D.Impulse);

    }
}

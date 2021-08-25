using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An asteroid
/// </summary>
public class Asteroid : MonoBehaviour
{
    [SerializeField]
    Sprite asteroidSprite0;
    [SerializeField]
    Sprite asteroidSprite1;
    [SerializeField]
    Sprite asteroidSprite2;

    private float randomAngle;
    private CircleCollider2D _circleCollider2D;
	/// <summary>
	/// Use this for initialization
	/// </summary>
	void Start()
	{
        // set random sprite for asteroid
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        int spriteNumber = Random.Range(0, 3);
        if (spriteNumber < 1)
        {
            spriteRenderer.sprite = asteroidSprite0;
        }
        else if (spriteNumber < 2)
        {
            spriteRenderer.sprite = asteroidSprite1;
        }
        else
        {
            spriteRenderer.sprite = asteroidSprite2;
        }
	}

    /// <summary>
    /// Starts the asteroid moving in the given direction
    /// </summary>
    /// <param name="direction">direction for the asteroid to move</param>
    /// <param name="position">position for the asteroid</param>
    public void Initialize(Direction direction, Vector3 position)
    {
        // set asteroid position
        transform.position = position;

        // set random angle based on direction
        float angle;
        randomAngle = Random.value * 30f * Mathf.Deg2Rad;
        if (direction == Direction.Up)
        {
            angle = 75 * Mathf.Deg2Rad + randomAngle;
        }
        else if (direction == Direction.Left)
        {
            angle = 165 * Mathf.Deg2Rad + randomAngle;
        }
        else if (direction == Direction.Down)
        {
            angle = 255 * Mathf.Deg2Rad + randomAngle;
        }
        else
        {
            angle = -15 * Mathf.Deg2Rad + randomAngle;
        }

        ApplyImpulseForce(angle);
    }

    public void ApplyImpulseForce(float angle)
    {
        // apply impulse force to get asteroid moving
        const float MinImpulseForce = 1f;
        const float MaxImpulseForce = 3f;
        Vector2 moveDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(moveDirection * magnitude, ForceMode2D.Impulse);
    }

    /// <summary>
    /// Destroys the asteroid on collision with a bullet
    /// </summary>
    /// <param name="coll">collision info</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            AudioManager.Play(AudioClipName.AsteroidHit);
            //Cutting its scale and collider half and destroy bullet
            Vector3 temp = transform.localScale;
            temp.x = temp.x / 2;
            temp.y = temp.y / 2;
            transform.localScale = temp;
            _circleCollider2D = GetComponent<CircleCollider2D>();
            _circleCollider2D.radius = _circleCollider2D.radius / 2;
            Destroy(other.gameObject);
            
            if (transform.localScale.x < 0.5)
            {
                Destroy(gameObject);
            }
            else
            {
                //Instantiate two smaller asteroids and give them force
                //Delete the original one
                GameObject smallerAsteroid1 = Instantiate(gameObject, transform.localPosition, Quaternion.identity);
                smallerAsteroid1.GetComponent<Asteroid>().ApplyImpulseForce(Random.Range(0,2 * Mathf.PI));
                GameObject smallerAsteroid2 = Instantiate(gameObject, transform.localPosition, Quaternion.identity);
                smallerAsteroid2.GetComponent<Asteroid>().ApplyImpulseForce(Random.Range(0,2 * Mathf.PI));
                Destroy(gameObject);
            }
            
        }
    }
}

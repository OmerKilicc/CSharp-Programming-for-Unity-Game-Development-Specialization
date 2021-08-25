using UnityEngine;
using Random = UnityEngine.Random;


public class Asteroid : MonoBehaviour
{
    [SerializeField]  Sprite greenSprite;
    [SerializeField]  Sprite whiteSprite;
    [SerializeField]  Sprite magentaSprite;
    // Start is called before the first frame update
    void Start()
    {
        PickRandomSprite();
        ApllyImpulseRandomForce();
    }

    void PickRandomSprite()
    {
        int randomSprite = Random.Range(0, 2);
        print(randomSprite);
        if (randomSprite == 0)
        {
            GetComponent<SpriteRenderer>().sprite = greenSprite;
        }
        else if (randomSprite == 1)
        {
            GetComponent<SpriteRenderer>().sprite = whiteSprite;
        }
        else if (randomSprite == 2)
        {
            GetComponent<SpriteRenderer>().sprite = magentaSprite;
        }
        
    }

    // apply impulse force to get game object moving
    void ApllyImpulseRandomForce()
    {
        const float MinImpulseForce = 3f;
        const float MaxImpulseForce = 5f;
        
        float angle = Random.Range(0, 2 * Mathf.PI);
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        
        GetComponent<Rigidbody2D>().AddForce(direction * magnitude,ForceMode2D.Impulse);
        
    }

}

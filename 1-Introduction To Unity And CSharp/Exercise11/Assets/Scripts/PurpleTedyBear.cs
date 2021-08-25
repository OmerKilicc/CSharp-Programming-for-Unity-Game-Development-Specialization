using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurpleTedyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.x = newScale.x * 3;
        transform.localScale = newScale;
    }

    
}

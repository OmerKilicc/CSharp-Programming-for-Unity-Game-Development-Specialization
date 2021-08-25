using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenTedyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.y = newScale.y * 3;
        transform.localScale = newScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

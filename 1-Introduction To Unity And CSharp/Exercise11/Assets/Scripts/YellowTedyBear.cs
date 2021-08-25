using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowTedyBear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 newScale = transform.localScale;
        newScale.x = newScale.x * 4;
        newScale.y = newScale.y * 4;
        transform.localScale = newScale;

    }

    // Update is called once per frame

}

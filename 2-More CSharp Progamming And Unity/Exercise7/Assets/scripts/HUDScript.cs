using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    [SerializeField]  
    Text textComponent;

    private int bounces = 0;

    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = "Bounces: " + bounces.ToString();
    }

    public void AddBounce()
    {
        bounces++;
        textComponent.text = "Bounces: " + bounces.ToString();
    }
}

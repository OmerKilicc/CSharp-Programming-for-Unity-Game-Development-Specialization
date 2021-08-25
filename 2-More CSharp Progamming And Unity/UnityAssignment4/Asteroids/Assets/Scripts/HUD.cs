using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    [SerializeField] 
    Text _text;

    private float elapsedSeconds = 0;
    private bool isTimerRunning = true;
    
    
    // Start is called before the first frame update
    void Start()
    {
        _text.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        elapsedSeconds = elapsedSeconds + Time.deltaTime;
        if (isTimerRunning)
        {
            _text.text = Convert.ToString(Convert.ToInt64(elapsedSeconds));
        }
        
    }

    public void StopGameTimer()
    {
        isTimerRunning = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/// <summary>
/// A teddy bear spawner
/// </summary>
public class RockSpawner : MonoBehaviour
{
    // needed for spawning
    [SerializeField] private GameObject greenRock;
    [SerializeField] private GameObject magentaRock;
    [SerializeField] private GameObject whiteRock;
    
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // check for time to spawn a new teddy bear
        if (GameObject.FindGameObjectsWithTag("Rock").Length < 3)
        {
            SpawnRock();
        }
    }

    /// <summary>
    /// Spawns a new rock  at the center of the camera
    /// </summary>
    void SpawnRock()
    {
        // create rocks in the center of the camera
        Vector3 location = new Vector3(0, 0, 0);
        int randomPrefab = Random.Range(0, 2);
        if (randomPrefab == 0)
        {
            GameObject rock = Instantiate(greenRock) as GameObject;
        }
        else if(randomPrefab == 1)
        {
            GameObject rock = Instantiate(magentaRock) as GameObject;
        }
        else
        {
            GameObject rock = Instantiate(whiteRock) as GameObject;
        }
        
    }
}

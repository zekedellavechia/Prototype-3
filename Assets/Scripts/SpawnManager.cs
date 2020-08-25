using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3(25, 0, 0);
    public float timeStart = 2f;
    public float timeRepeat = 5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", timeStart, timeRepeat);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnObstacle ()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }
}

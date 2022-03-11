using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float XRange = 53f;
    private float Yrange = 2.7f;
    public GameObject obstacleprefab;
    private float delay = 3;
    private float startDelay=2;
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnObstacle()
    {
        Vector2 position = new Vector2(XRange, Yrange);
        Instantiate(obstacleprefab, position, obstacleprefab.transform.rotation);
    }
}

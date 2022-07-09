using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject obstaclePrefab;

    public float height = .5f;

    public float maxTime = 0;
    public float destroyDelay = .5f;
    private float timer = 0;

    void Start()
    {
        InstantiateObstacle();
    }
    void Update()
    {
        if (timer > maxTime)
        {
            #region Instantiation

            InstantiateObstacle();
            #endregion
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void InstantiateObstacle()
    {
        GameObject go = Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
        go.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
        go.transform.parent = transform;

        Destroy(go, destroyDelay);
    }
}

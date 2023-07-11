using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{

    public GameObject fallingBlockPrefab;
    public Vector2 spawnSizeMinMax;

    public Vector2 secondsBetweenSpawnsMinMax;
    public float spawnAngleMax;

    float newxtSpawn;

    Vector2 screenHalfSizeWorldUnity;

    void Start()
    {
        screenHalfSizeWorldUnity = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > newxtSpawn)
        {
            float secondsBetweenSpawns = Mathf.Lerp(secondsBetweenSpawnsMinMax.y, secondsBetweenSpawnsMinMax.x, Difficult.GetSecondsToMaxDifficult());
            newxtSpawn = Time.time + secondsBetweenSpawns;

            float spawnSize = Random.Range(spawnSizeMinMax.x, spawnSizeMinMax.y);
            float spawnAngle = Random.Range(-spawnAngleMax, spawnAngleMax);
            Vector2 spawnPos = new Vector2(Random.Range(-screenHalfSizeWorldUnity.x, screenHalfSizeWorldUnity.x), screenHalfSizeWorldUnity.y + spawnSize + 1);
            GameObject newBlock = (GameObject)Instantiate(fallingBlockPrefab, spawnPos, Quaternion.Euler(Vector3.forward * spawnAngle));
            newBlock.transform.localScale = Vector3.one * spawnSize;
        }
        

    }
}

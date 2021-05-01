using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Vector2 spawnTime;
    public GameObject[] myObjects = new GameObject[10];

    private float _nextSpawn = 0f;


    void Update()
    {
        if (Time.time > _nextSpawn)
        {
            float spawn = Random.Range(spawnTime.x, spawnTime.y);
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 pos = new Vector3(Random.Range(-4f, 4f), 0, 0) + transform.position;
            GameObject instantiatedObject = Instantiate(myObjects[randomIndex], pos, Quaternion.identity) as GameObject;
            _nextSpawn = Time.time + spawn;
        }
    }

}



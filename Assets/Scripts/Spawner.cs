using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject mouse;

    public GameObject cheese1;
    public GameObject cheese2;

    public float spawnTimer;
    private float spawnTimerTmp;

    void Start()
    {
        
    }

    void Update()
    {
        spawnTimerTmp += Time.deltaTime;
        if (spawnTimerTmp >= spawnTimer)
        {
            SpawnMouse();
            spawnTimerTmp = 0f;
        }
    }

    private void SpawnMouse()
    {
        GameObject m = Instantiate(mouse, transform.position, Quaternion.identity);
        if (Random.Range(0f,1f) <= 0.5f)
        {
            m.GetComponent<Mouse>().target = cheese1;
        }
        else
        {
            m.GetComponent<Mouse>().target = cheese2;
        }
    }
}
